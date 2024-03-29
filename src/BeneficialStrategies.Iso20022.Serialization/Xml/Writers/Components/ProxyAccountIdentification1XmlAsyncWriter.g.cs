﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for ProxyAccountIdentification1.  ISO2002 ID# _luR59Xh2EeidzqjNEfehPg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Amounts;
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="ProxyAccountIdentification1"/>.
    /// </summary>
    public class ProxyAccountIdentification1XmlAsyncWriter : ISubordinateXmlAsyncWriter<ProxyAccountIdentification1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<ProxyAccountType1Choice_> type;
        private readonly Max2048TextXmlAsyncWriter identification;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public ProxyAccountIdentification1XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<ProxyAccountType1Choice_> type,
            Max2048TextXmlAsyncWriter identification
        )
        {
            this.type = type;
            this.identification = identification;
        }
        public async Task WriteAsync(XmlWriter writer, ProxyAccountIdentification1 valueBeingSerialized, string isoNamespace)
        {
            // Type Optional ProxyAccountType1Choice ProxyAccountType1Choice_
            if ( valueBeingSerialized.Type is ProxyAccountType1Choice_ populatedType)
            {
                await writer.WriteStartElementAsync(null, "Tp", isoNamespace );
                await type.WriteAsync(writer, populatedType, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Identification Required Max2048Text System.String
            await writer.WriteStartElementAsync(null, "Id", isoNamespace );
            await identification.WriteAsync(writer, valueBeingSerialized.Identification, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
