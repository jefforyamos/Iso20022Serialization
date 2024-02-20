﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for OriginalGroupHeader16.  ISO2002 ID# _Y1X8AW49EeiU9cctagi5ow.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="OriginalGroupHeader16"/>.
    /// </summary>
    public class OriginalGroupHeader16XmlAsyncWriter : ISubordinateXmlAsyncWriter<OriginalGroupHeader16>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IMax35TextXmlAsyncWriter originalMessageIdentification;
        private readonly IMax35TextXmlAsyncWriter originalMessageNameIdentification;
        private readonly IISODateTimeXmlAsyncWriter originalCreationDateTime;
        private readonly ISubordinateXmlAsyncWriter<PaymentReversalReason9> reversalReasonInformation;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public OriginalGroupHeader16XmlAsyncWriter
        (
            IMax35TextXmlAsyncWriter originalMessageIdentification,
            IMax35TextXmlAsyncWriter originalMessageNameIdentification,
            IISODateTimeXmlAsyncWriter originalCreationDateTime,
            ISubordinateXmlAsyncWriter<PaymentReversalReason9> reversalReasonInformation
        )
        {
            this.originalMessageIdentification = originalMessageIdentification;
            this.originalMessageNameIdentification = originalMessageNameIdentification;
            this.originalCreationDateTime = originalCreationDateTime;
            this.reversalReasonInformation = reversalReasonInformation;
        }
        public async Task WriteAsync(XmlWriter writer, OriginalGroupHeader16 value, string isoNamespace)
        {
            // OriginalMessageIdentification Required Max35Text System.String
            await writer.WriteStartElementAsync(null, "OrgnlMsgId", isoNamespace );
            await originalMessageIdentification.WriteAsync(writer, value.OriginalMessageIdentification, isoNamespace);
            await writer.WriteEndElementAsync();
            // OriginalMessageNameIdentification Required Max35Text System.String
            await writer.WriteStartElementAsync(null, "OrgnlMsgNmId", isoNamespace );
            await originalMessageNameIdentification.WriteAsync(writer, value.OriginalMessageNameIdentification, isoNamespace);
            await writer.WriteEndElementAsync();
            // OriginalCreationDateTime Optional ISODateTime System.DateTime
            if ( value.OriginalCreationDateTime is System.DateTime populatedOriginalCreationDateTime)
            {
                await writer.WriteStartElementAsync(null, "OrgnlCreDtTm", isoNamespace );
                await originalCreationDateTime.WriteAsync(writer, populatedOriginalCreationDateTime, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // ReversalReasonInformation Optional PaymentReversalReason9 PaymentReversalReason9
            if ( value.ReversalReasonInformation is PaymentReversalReason9 populatedReversalReasonInformation)
            {
                await writer.WriteStartElementAsync(null, "RvslRsnInf", isoNamespace );
                await reversalReasonInformation.WriteAsync(writer, populatedReversalReasonInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}