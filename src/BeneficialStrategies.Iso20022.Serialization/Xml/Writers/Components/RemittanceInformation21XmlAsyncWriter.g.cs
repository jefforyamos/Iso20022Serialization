﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for RemittanceInformation21.  ISO2002 ID# _n3SnQd4lEeqt1ZcLzWyWFw.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="RemittanceInformation21"/>.
    /// </summary>
    public class RemittanceInformation21XmlAsyncWriter : ISubordinateXmlAsyncWriter<RemittanceInformation21>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max140TextXmlAsyncWriter unstructured;
        private readonly ISubordinateXmlAsyncWriter<StructuredRemittanceInformation17> structured;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public RemittanceInformation21XmlAsyncWriter
        (
            Max140TextXmlAsyncWriter unstructured,
            ISubordinateXmlAsyncWriter<StructuredRemittanceInformation17> structured
        )
        {
            this.unstructured = unstructured;
            this.structured = structured;
        }
        public async Task WriteAsync(XmlWriter writer, RemittanceInformation21 valueBeingSerialized, string isoNamespace)
        {
            // Unstructured Optional Max140Text System.String
            if ( valueBeingSerialized.Unstructured is System.String populatedUnstructured)
            {
                await writer.WriteStartElementAsync(null, "Ustrd", isoNamespace );
                await unstructured.WriteAsync(writer, populatedUnstructured, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Structured Optional StructuredRemittanceInformation17 StructuredRemittanceInformation17
            if ( valueBeingSerialized.Structured is StructuredRemittanceInformation17 populatedStructured)
            {
                await writer.WriteStartElementAsync(null, "Strd", isoNamespace );
                await structured.WriteAsync(writer, populatedStructured, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
