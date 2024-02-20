﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for ReferredDocumentInformation7.  ISO2002 ID# _0X1uUzq4EeWZFYSPlduMhw.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="ReferredDocumentInformation7"/>.
    /// </summary>
    public class ReferredDocumentInformation7XmlAsyncWriter : ISubordinateXmlAsyncWriter<ReferredDocumentInformation7>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<ReferredDocumentType4> type;
        private readonly IMax35TextXmlAsyncWriter number;
        private readonly IISODateXmlAsyncWriter relatedDate;
        private readonly ISubordinateXmlAsyncWriter<DocumentLineInformation1> lineDetails;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public ReferredDocumentInformation7XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<ReferredDocumentType4> type,
            IMax35TextXmlAsyncWriter number,
            IISODateXmlAsyncWriter relatedDate,
            ISubordinateXmlAsyncWriter<DocumentLineInformation1> lineDetails
        )
        {
            this.type = type;
            this.number = number;
            this.relatedDate = relatedDate;
            this.lineDetails = lineDetails;
        }
        public async Task WriteAsync(XmlWriter writer, ReferredDocumentInformation7 value, string isoNamespace)
        {
            // Type Optional ReferredDocumentType4 ReferredDocumentType4
            if ( value.Type is ReferredDocumentType4 populatedType)
            {
                await writer.WriteStartElementAsync(null, "Tp", isoNamespace );
                await type.WriteAsync(writer, populatedType, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Number Optional Max35Text System.String
            if ( value.Number is System.String populatedNumber)
            {
                await writer.WriteStartElementAsync(null, "Nb", isoNamespace );
                await number.WriteAsync(writer, populatedNumber, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // RelatedDate Optional ISODate System.DateOnly
            if ( value.RelatedDate is System.DateOnly populatedRelatedDate)
            {
                await writer.WriteStartElementAsync(null, "RltdDt", isoNamespace );
                await relatedDate.WriteAsync(writer, populatedRelatedDate, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // LineDetails Optional DocumentLineInformation1 DocumentLineInformation1
            if ( value.LineDetails is DocumentLineInformation1 populatedLineDetails)
            {
                await writer.WriteStartElementAsync(null, "LineDtls", isoNamespace );
                await lineDetails.WriteAsync(writer, populatedLineDetails, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}