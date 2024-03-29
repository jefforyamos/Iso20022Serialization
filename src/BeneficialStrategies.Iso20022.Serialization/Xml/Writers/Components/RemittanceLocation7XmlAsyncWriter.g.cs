﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for RemittanceLocation7.  ISO2002 ID# _-BcUm24-EeiU9cctagi5ow.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="RemittanceLocation7"/>.
    /// </summary>
    public class RemittanceLocation7XmlAsyncWriter : ISubordinateXmlAsyncWriter<RemittanceLocation7>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max35TextXmlAsyncWriter remittanceIdentification;
        private readonly ISubordinateXmlAsyncWriter<RemittanceLocationData1> remittanceLocationDetails;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public RemittanceLocation7XmlAsyncWriter
        (
            Max35TextXmlAsyncWriter remittanceIdentification,
            ISubordinateXmlAsyncWriter<RemittanceLocationData1> remittanceLocationDetails
        )
        {
            this.remittanceIdentification = remittanceIdentification;
            this.remittanceLocationDetails = remittanceLocationDetails;
        }
        public async Task WriteAsync(XmlWriter writer, RemittanceLocation7 valueBeingSerialized, string isoNamespace)
        {
            // RemittanceIdentification Optional Max35Text System.String
            if ( valueBeingSerialized.RemittanceIdentification is System.String populatedRemittanceIdentification)
            {
                await writer.WriteStartElementAsync(null, "RmtId", isoNamespace );
                await remittanceIdentification.WriteAsync(writer, populatedRemittanceIdentification, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // RemittanceLocationDetails Optional RemittanceLocationData1 RemittanceLocationData1
            if ( valueBeingSerialized.RemittanceLocationDetails is RemittanceLocationData1 populatedRemittanceLocationDetails)
            {
                await writer.WriteStartElementAsync(null, "RmtLctnDtls", isoNamespace );
                await remittanceLocationDetails.WriteAsync(writer, populatedRemittanceLocationDetails, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
