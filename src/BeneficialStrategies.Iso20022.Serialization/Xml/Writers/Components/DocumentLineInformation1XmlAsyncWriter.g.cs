﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for DocumentLineInformation1.  ISO2002 ID# _Cy5dt6JpEeKmspP9k_hIRQ.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="DocumentLineInformation1"/>.
    /// </summary>
    public class DocumentLineInformation1XmlAsyncWriter : ISubordinateXmlAsyncWriter<DocumentLineInformation1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<DocumentLineIdentification1> identification;
        private readonly Max2048TextXmlAsyncWriter description;
        private readonly ISubordinateXmlAsyncWriter<RemittanceAmount3> amount;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public DocumentLineInformation1XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<DocumentLineIdentification1> identification,
            Max2048TextXmlAsyncWriter description,
            ISubordinateXmlAsyncWriter<RemittanceAmount3> amount
        )
        {
            this.identification = identification;
            this.description = description;
            this.amount = amount;
        }
        public async Task WriteAsync(XmlWriter writer, DocumentLineInformation1 valueBeingSerialized, string isoNamespace)
        {
            // Identification Unknown DocumentLineIdentification1 DocumentLineIdentification1
            // Warning: Multiplicity unknown
            foreach ( var item in valueBeingSerialized.Identification)
            {
                await writer.WriteStartElementAsync(null, "Id", isoNamespace );
                await identification.WriteAsync(writer, item , isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Description Optional Max2048Text System.String
            if ( valueBeingSerialized.Description is System.String populatedDescription)
            {
                await writer.WriteStartElementAsync(null, "Desc", isoNamespace );
                await description.WriteAsync(writer, populatedDescription, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Amount Optional RemittanceAmount3 RemittanceAmount3
            if ( valueBeingSerialized.Amount is RemittanceAmount3 populatedAmount)
            {
                await writer.WriteStartElementAsync(null, "Amt", isoNamespace );
                await amount.WriteAsync(writer, populatedAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
