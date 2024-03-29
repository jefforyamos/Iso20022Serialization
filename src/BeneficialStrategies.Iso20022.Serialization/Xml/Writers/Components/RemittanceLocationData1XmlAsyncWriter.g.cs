﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for RemittanceLocationData1.  ISO2002 ID# _-LRmB24-EeiU9cctagi5ow.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="RemittanceLocationData1"/>.
    /// </summary>
    public class RemittanceLocationData1XmlAsyncWriter : ISubordinateXmlAsyncWriter<RemittanceLocationData1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly RemittanceLocationMethod2CodeXmlAsyncWriter method;
        private readonly Max2048TextXmlAsyncWriter electronicAddress;
        private readonly ISubordinateXmlAsyncWriter<NameAndAddress16> postalAddress;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public RemittanceLocationData1XmlAsyncWriter
        (
            RemittanceLocationMethod2CodeXmlAsyncWriter method,
            Max2048TextXmlAsyncWriter electronicAddress,
            ISubordinateXmlAsyncWriter<NameAndAddress16> postalAddress
        )
        {
            this.method = method;
            this.electronicAddress = electronicAddress;
            this.postalAddress = postalAddress;
        }
        public async Task WriteAsync(XmlWriter writer, RemittanceLocationData1 valueBeingSerialized, string isoNamespace)
        {
            // Method Required RemittanceLocationMethod2Code RemittanceLocationMethod2Code
            await writer.WriteStartElementAsync(null, "Mtd", isoNamespace );
            await method.WriteAsync(writer, valueBeingSerialized.Method, isoNamespace);
            await writer.WriteEndElementAsync();
            // ElectronicAddress Optional Max2048Text System.String
            if ( valueBeingSerialized.ElectronicAddress is System.String populatedElectronicAddress)
            {
                await writer.WriteStartElementAsync(null, "ElctrncAdr", isoNamespace );
                await electronicAddress.WriteAsync(writer, populatedElectronicAddress, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // PostalAddress Optional NameAndAddress16 NameAndAddress16
            if ( valueBeingSerialized.PostalAddress is NameAndAddress16 populatedPostalAddress)
            {
                await writer.WriteStartElementAsync(null, "PstlAdr", isoNamespace );
                await postalAddress.WriteAsync(writer, populatedPostalAddress, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
