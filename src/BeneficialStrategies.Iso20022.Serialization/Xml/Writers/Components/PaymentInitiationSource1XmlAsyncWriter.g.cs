﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for PaymentInitiationSource1.  ISO2002 ID# _qBeboMQJEemsic1bQcEtLA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Components
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="PaymentInitiationSource1"/>.
    /// </summary>
    public class PaymentInitiationSource1XmlAsyncWriter : ISubordinateXmlAsyncWriter<PaymentInitiationSource1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max140TextXmlAsyncWriter name;
        private readonly Max35TextXmlAsyncWriter provider;
        private readonly Max35TextXmlAsyncWriter version;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public PaymentInitiationSource1XmlAsyncWriter
        (
            Max140TextXmlAsyncWriter name,
            Max35TextXmlAsyncWriter provider,
            Max35TextXmlAsyncWriter version
        )
        {
            this.name = name;
            this.provider = provider;
            this.version = version;
        }
        public async Task WriteAsync(XmlWriter writer, PaymentInitiationSource1 valueBeingSerialized, string isoNamespace)
        {
            // Name Required Max140Text System.String
            await writer.WriteStartElementAsync(null, "Nm", isoNamespace );
            await name.WriteAsync(writer, valueBeingSerialized.Name, isoNamespace);
            await writer.WriteEndElementAsync();
            // Provider Optional Max35Text System.String
            if ( valueBeingSerialized.Provider is System.String populatedProvider)
            {
                await writer.WriteStartElementAsync(null, "Prvdr", isoNamespace );
                await provider.WriteAsync(writer, populatedProvider, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Version Optional Max35Text System.String
            if ( valueBeingSerialized.Version is System.String populatedVersion)
            {
                await writer.WriteStartElementAsync(null, "Vrsn", isoNamespace );
                await version.WriteAsync(writer, populatedVersion, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
