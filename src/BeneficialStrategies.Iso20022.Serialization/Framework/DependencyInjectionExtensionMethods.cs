using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.Codesets;
using System.Reflection;
using System.Collections.Immutable;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Choices.AcceptedReason10Choice;
using System.Diagnostics;

namespace BeneficialStrategies.Iso20022.Serialization;

public static class DependencyInjectionExtensionMethods
{
    // public static HostApplicationBuilder RegisterIso20022XmlSerializers( this HostApplicationBuilder builder )
    // {
    //     builder.Services.AddSingleton<IXmlAsyncWriter<BeneficialStrategies.Iso20022.pain.CustomerCreditTransferInitiationV11>
    //         ,BeneficialStrategies.Iso20022.Serialization.Xml.Writers.pain.CustomerCreditTransferInitiationV11XmlAsyncWriter>();

    //     return builder;
    // }
    public static IServiceCollection RegisterIso20022XmlSerializers( this IServiceCollection services )
    {
        services.AddSingleton<IXmlAsyncWriter<BeneficialStrategies.Iso20022.pain.CustomerCreditTransferInitiationV11>
            ,BeneficialStrategies.Iso20022.Serialization.Xml.Writers.pain.CustomerCreditTransferInitiationV11XmlAsyncWriter>();

        var assembly = typeof(DependencyInjectionExtensionMethods).Assembly;
        
        // System.Collections.Generic.HashSet<string> interfaceNamesToRegister = ["ISubordinateXmlAsyncWriter", "IOuterRecord"];

        string codeSetNamespace = typeof(Xml.Codesets.Authorisation1CodeXmlAsyncWriter).Namespace!;
        string abstractChoiceNamespace = typeof( Xml.Choices.AccountIdentification4ChoiceXmlAsyncWriter).Namespace!;

        var subordinateRecordsQuery = from recType in assembly.GetTypes() 
                where recType.IsInterface == false && recType.IsAbstract == false
                let subordinateXmlInterface = recType.GetInterfaces().FirstOrDefault(r => r.Name.Contains("ISubordinateXml"))
                let xmlAsyncWriterInterface = recType.GetInterfaces().FirstOrDefault(r => r.Name.Contains("IXmlAsyncWriter"))
                let simpleTypeWriterInterace = recType.GetInterfaces().FirstOrDefault( r => r.Name.Contains("ISimpleTypeSubordinateXmlAsyncWriter"))
                let nmspace = recType.Namespace ?? "UNKNOWN" 
                let isConcreteChoice = nmspace.Contains(".Choices.")
                let isSimpleType = nmspace.Contains(".SimpleTypes")
                let isCodesetWriter = recType.Namespace == codeSetNamespace
                let shouldRegisterConcrete = isCodesetWriter || isConcreteChoice || isSimpleType
                select new 
                { 
                    SubordinateXmlInterface = subordinateXmlInterface,
                    XmlAsyncWriterInterface = xmlAsyncWriterInterface,
                    SimpleTypeWriterInterface = simpleTypeWriterInterace,
                    ConcreteType = recType, 
                    ShouldRegisterConcrete = shouldRegisterConcrete
                };

        var subordinateRecordsArray = subordinateRecordsQuery.ToArray();

        var missingRec = subordinateRecordsArray.FirstOrDefault(r => r.ConcreteType == typeof(Xml.Writers.SimpleTypes.ExternalFinancialInstitutionIdentification1CodeXmlAsyncWriter)); 
        Debug.Assert( missingRec != null);
        Debug.Assert( missingRec.ShouldRegisterConcrete);

        foreach( var registration in subordinateRecordsArray.Where( t => t.ShouldRegisterConcrete )) 
            services.AddSingleton(registration.ConcreteType);

        foreach( var registration in subordinateRecordsArray.Where( r => r.XmlAsyncWriterInterface is not null) )
            services.AddSingleton(registration.XmlAsyncWriterInterface, registration.ConcreteType);

        foreach( var registration in subordinateRecordsArray.Where(r => r.SubordinateXmlInterface is not null))
            services.AddSingleton(registration.SubordinateXmlInterface, registration.ConcreteType);

        foreach( var registration in subordinateRecordsArray.Where(r => r.SimpleTypeWriterInterface is not null))
            services.AddSingleton(registration.SimpleTypeWriterInterface, registration.ConcreteType);

        // Authorisation1ChoiceCodeXmlAsyncWriter
        // Exception thrown: 'System.InvalidOperationException' in Microsoft.Extensions.DependencyInjection.dll: 
        // 'Unable to resolve service for type 'BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.Authorisation1Choice.Authorisation1ChoiceCodeXmlAsyncWriter' 
        // while attempting to activate 'BeneficialStrategies.Iso20022.Serialization.Xml.Choices.Authorisation1ChoiceXmlAsyncWriter'.'


        var lookAtThis = assembly.GetTypes().Where(t => t.Name == "Authorisation1ChoiceCodeXmlAsyncWriter");


        return services;
    }



}