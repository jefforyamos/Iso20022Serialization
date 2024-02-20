﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for DocumentLineInformation1.  ISO2002 ID# _Cy5dt6JpEeKmspP9k_hIRQ.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="DocumentLineInformation1"/>.
    /// </summary>
    public class DocumentLineInformation1XmlAsyncWriter : ISubordinateXmlAsyncWriter<DocumentLineInformation1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<DocumentLineIdentification1> identification;
        private readonly IMax2048TextXmlAsyncWriter description;
        private readonly ISubordinateXmlAsyncWriter<RemittanceAmount3> amount;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public DocumentLineInformation1XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<DocumentLineIdentification1> identification,
            IMax2048TextXmlAsyncWriter description,
            ISubordinateXmlAsyncWriter<RemittanceAmount3> amount
        )
        {
            this.identification = identification;
            this.description = description;
            this.amount = amount;
        }
        public async Task WriteAsync(XmlWriter writer, DocumentLineInformation1 value, string isoNamespace)
        {
            // Identification Unknown DocumentLineIdentification1 DocumentLineIdentification1
            // Description Optional Max2048Text System.String
            if ( value.Description is System.String populatedDescription)
            {
                await writer.WriteStartElementAsync(null, "Desc", isoNamespace );
                await description.WriteAsync(writer, populatedDescription, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Amount Optional RemittanceAmount3 RemittanceAmount3
            if ( value.Amount is RemittanceAmount3 populatedAmount)
            {
                await writer.WriteStartElementAsync(null, "Amt", isoNamespace );
                await amount.WriteAsync(writer, populatedAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}