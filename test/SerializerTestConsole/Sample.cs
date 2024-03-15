using BeneficialStrategies.Iso20022.pain;
using Beneficial = BeneficialStrategies.Iso20022;
using BeneficialStrategies.Iso20022.Codesets;

public static class Sample
{
    public static CustomerCreditTransferInitiationV11 CustomerCreditTransferInitiationV11 = new Beneficial.pain.CustomerCreditTransferInitiationV11
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
        BatchBooking = "false",
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
                            // Add more types of remittances here, use shift-spacebar for pop-up help
                        }
                    ,
                    // Optionally add Unstructured information here
                },
                // LOTS more stuff you can add at this level
            },
            // LOTS more you can add at this level
    },
    // Optionally add Supplementary data at this level
};
}