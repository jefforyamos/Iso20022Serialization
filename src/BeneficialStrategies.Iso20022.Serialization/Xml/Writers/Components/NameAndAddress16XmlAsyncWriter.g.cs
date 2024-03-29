﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for NameAndAddress16.  ISO2002 ID# _9MDku24-EeiU9cctagi5ow.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="NameAndAddress16"/>.
    /// </summary>
    public class NameAndAddress16XmlAsyncWriter : ISubordinateXmlAsyncWriter<NameAndAddress16>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max140TextXmlAsyncWriter name;
        private readonly ISubordinateXmlAsyncWriter<PostalAddress24> address;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public NameAndAddress16XmlAsyncWriter
        (
            Max140TextXmlAsyncWriter name,
            ISubordinateXmlAsyncWriter<PostalAddress24> address
        )
        {
            this.name = name;
            this.address = address;
        }
        public async Task WriteAsync(XmlWriter writer, NameAndAddress16 valueBeingSerialized, string isoNamespace)
        {
            // Name Required Max140Text System.String
            await writer.WriteStartElementAsync(null, "Nm", isoNamespace );
            await name.WriteAsync(writer, valueBeingSerialized.Name, isoNamespace);
            await writer.WriteEndElementAsync();
            // Address Required PostalAddress24 PostalAddress24
            await writer.WriteStartElementAsync(null, "Adr", isoNamespace );
            await address.WriteAsync(writer, valueBeingSerialized.Address, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
