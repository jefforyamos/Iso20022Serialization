﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for SupplementaryData1.  ISO2002 ID# _Qn0zC9p-Ed-ak6NoX_4Aeg_468227563.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Components
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="SupplementaryData1"/>.
    /// </summary>
    public class SupplementaryData1XmlAsyncWriter : ISubordinateXmlAsyncWriter<SupplementaryData1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IMax350TextXmlAsyncWriter placeAndName;
        private readonly ISubordinateXmlAsyncWriter<SupplementaryDataEnvelope1> envelope;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public SupplementaryData1XmlAsyncWriter
        (
            IMax350TextXmlAsyncWriter placeAndName,
            ISubordinateXmlAsyncWriter<SupplementaryDataEnvelope1> envelope
        )
        {
            this.placeAndName = placeAndName;
            this.envelope = envelope;
        }
        public async Task WriteAsync(XmlWriter writer, SupplementaryData1 value, string isoNamespace)
        {
            // PlaceAndName Optional Max350Text System.String
            if ( value.PlaceAndName is System.String populatedPlaceAndName)
            {
                await writer.WriteStartElementAsync(null, "PlcAndNm", isoNamespace );
                await placeAndName.WriteAsync(writer, populatedPlaceAndName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Envelope Required SupplementaryDataEnvelope1 SupplementaryDataEnvelope1
            await writer.WriteStartElementAsync(null, "Envlp", isoNamespace );
            await envelope.WriteAsync(writer, value.Envelope, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}