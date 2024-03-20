# Beneficial Strategies ISO20022 Serialization Library

This project contains enterprise XML serialization consistent with the the [ISO20022](https://iso20022.org) standard.
It is a companion of and dependency of the [ISO20022 Library](https://www.nuget.org/packages/com.beneficialstrategies.iso20022) that defines the message structure.

## Description

This library provides DI regristrations for XML serializers that perform xml serialization services upon the records in the library.
Some implementation notes:

- The serializers as implemented hold no state.
- Since they are stateless, they are registered as singletons to minimize the memory footprint.
- The implementation follows roughly the same hierarchy as the message implementation.
- Some serializers my be injected twice into a single class corresponding to two members of the same type. Since the implementations are singletons, this in reality is two references to the same instance.
- The hierarchical nature of the implementation makes it easy for you to substitute one small piece of the serialization puzzle.  You simply:
  - Create your own implementation of the ISubordinateXmlAsyncWriter&lt;TMessageRecordType&gt;.
  - Register your class with the DI after calling RegisterIso200022XmlSerializers.
  - Your class will be called instead of the one in this library.
- You should always validate messages prior to serialization. Validation will be provided in an additional library.
- Validation based on ISO20022-provided XSD schema is now done in testing in the serialization repository, but will later be extracted to its own companion library.

## Current limitations

- The initial implementation contains only a subset of messages and their dependencies, primarily PAIN.
- The initial implementation contains **no deserialization**.  It will be added to this library later.
- There is currently no serialization support for digital signatures.
- The initial release only supports .NET8.0.  Support for two prior versions is intended.

## Trying out the library

Start by creating a simple console app.

```CMD
mkdir IsoTest1
cd IsoTest1
dotnet new console
```

Now add references.

```CMD
dotnet add package Microsoft.Extensions.Hosting
dotnet add package BeneficialStrategies.Iso20022.Serialization --prerelease
```

To try using the messages, start by putting this using statement in the top of your Program.cs.

```C#
using Beneficial = BeneficialStrategies.Iso20022;
using BeneficialStrategies.Iso20022.Codesets;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BeneficialStrategies.Iso20022.Serialization;
using WriterInterface = BeneficialStrategies.Iso20022.Serialization.IXmlAsyncWriter<BeneficialStrategies.Iso20022.pain.CustomerCreditTransferInitiationV11>;
using System.Xml;
using System.Diagnostics;
using BeneficialStrategies.Iso20022.SchemaValidation;
using System.Xml.Linq;
using System.Xml.Schema;
```

You are now ready to initialize dependency injection and obtain a reference to a serializer.

```C#
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.RegisterIso20022XmlSerializers();
var host = builder.Build();
var serializer = host.Services.GetRequiredService<WriterInterface>();
```

Now, let's instance a message to serialize. This particular example was taken loosely from [a document](https://www.iso20022.org/business-area-message-set/81/1135/download) on the [Iso20022 web site](https://iso20022.org). You can start by declaring an instance

```C#
var myMessage = new Beneficial.pain.CustomerCreditTransferInitiationV11
{
    GroupHeader = new()
    {
        MessageIdentification = "ABC/120928/CCT001",
        CreationDateTime = new DateTime(2012, 09, 28, 14, 7, 0),
        NumberOfTransactions = "3",
        ControlSum = 11_500_000,
        InitiatingParty = new()
        {
            Name = "ABC Corporation",
            PostalAddress = new()
            {
                StreetName = "Times Square",
                BuildingNumber = "7",
                PostCode = "NY 10036",
                TownName = "New York",
                Country = "US"
            },
        },
    },
    PaymentInformation = new()
    {
        PaymentInformationIdentification = "ABC/086",
        PaymentMethod = PaymentMethod3Code.CreditTransfer,
        BatchBooking = "FALSE",
        RequestedExecutionDate = new Beneficial.Choices.DateAndDateTime2Choice.Date { Value = new DateOnly(2012, 09, 29) },
        Debtor = new()
        {
            Name = "ABC Corporation",
            PostalAddress = new()
            {
                StreetName = "Times Square",
                BuildingNumber = "7",
                PostCode = "NY 10036",
                TownName = "New York",
                Country = "US"
            },
            // Optionally add Contact details, other stuff here
        },
        DebtorAccount = new()
        {
            Identification = new Beneficial.Choices.AccountIdentification4Choice.Other
            {
                Identification = "00125574999",
            },
            // Lots more info you can add here
        },
        DebtorAgent = new()
        {
            FinancialInstitutionIdentification = new ()
            {
                BICFI = "BBBBUS33",
                // Lots more identifying information you can add here
            },
        },
        CreditTransferTransactionInformation =
        [
            new()
            {
                PaymentIdentification = new ()
                {
                    InstructionIdentification = "ABC/120928/CCT001/1",
                    EndToEndIdentification = "ABC/4562/2012-09-08",
                },
                Amount = new Beneficial.Choices.AmountType4Choice.InstructedAmount { Value = 10_000_000m },
                ChargeBearer = ChargeBearerType1Code.Shared,
                CreditorAgent = new()
                {
                    FinancialInstitutionIdentification = new()
                    {
                        BICFI = "AAAAGB2L",
                        // Tons of more identifying information you can optionally add here
                    },
                    // Optionally add branch information here
                },
                Creditor = new()
                {
                    Name = "DEF Electronics",
                    PostalAddress = new()
                    {
                        AddressLine = [
                            "Corn Exchange 5th Floor",
                            "Mark Lane 55",
                            "EC#R7NE London",
                            "GB"
                            ]
                    },
                    // Optionally add ContactDetails, CountryOfResidence, Identification here
                },
                CreditorAccount = new()
                {
                    Identification = new Beneficial.Choices.AccountIdentification4Choice.Other
                    {
                        Identification = "23683707994215",
                        // Optionally add issuer, schema name here 
                    },
                },
                Purpose = new Beneficial.Choices.Purpose2Choice.Code
                {
                    Value = ExternalPurpose1Code.InstantPaymentsForDonations, 
                },
                RemittanceInformation = new()
                {
                    Structured = 
                        new()
                        {
                            ReferredDocumentInformation =
                                new()
                                {
                                    Type = new()
                                    {
                                        CodeOrProprietary = new Beneficial.Choices.ReferredDocumentType3Choice.Code
                                        {
                                            Value = DocumentType6Code.CommercialInvoice,
                                        },
                                    },
                                    Number = "4562",
                                    RelatedDate = new DateOnly(2012,09,08),
                                    // Optionally add line details here
                                }
                            ,
                        }
                    ,
                },
            },
        ]
    },
};

```

Now that you have a serializer and a sample message, you are ready to perform serialization.

```C#
using var writer = XmlWriter.Create("MySerializedOutput.xml", new XmlWriterSettings { Indent = true , Async = true });
await serializer.WriteAsync(writer, myMessage);
writer.Close();
```

## Realistic enterprise usage

In it's most typical enterprise usage, the serializer will become an injected dependency in one of your implementation classes.

```C#
...
using BeneficialStrategies.Iso20022.Serialization;
...
public class SomeEnterpriseClass
{
    public SomeEnterpriseClass
    ( 
        ...
        IXmlAsyncWriter<CustomerCreditTransferInitiationV11> xmlSerializer,
        ...
    )
}
```

## Thank you

For more information about the project, see [the repository](https://github.com/jefforyamos/Iso20022Serialization).

This is provided free of charge under a very non-restrictive license as a good-faith contribution to the community.  Should you find this library useful, we are seeking corporate sponsorship. Please email us at [sponsor@beneficialstrategies.com](mailto:sponsor@beneficialstrategies.com) if your company might be willing to contribute to this worthy cause.

If you have questions or concerns about the implementation, please send developer comments or questions to [feedback@beneficialstrategies.com](mailto:feedback@beneficialstrategies.com).
