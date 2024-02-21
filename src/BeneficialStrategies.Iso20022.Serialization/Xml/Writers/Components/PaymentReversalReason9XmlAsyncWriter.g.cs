﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for PaymentReversalReason9.  ISO2002 ID# _YEpCuW49EeiU9cctagi5ow.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="PaymentReversalReason9"/>.
    /// </summary>
    public class PaymentReversalReason9XmlAsyncWriter : ISubordinateXmlAsyncWriter<PaymentReversalReason9>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<PartyIdentification135> originator;
        private readonly ISubordinateXmlAsyncWriter<ReversalReason4Choice_> reason;
        private readonly IMax105TextXmlAsyncWriter additionalInformation;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public PaymentReversalReason9XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<PartyIdentification135> originator,
            ISubordinateXmlAsyncWriter<ReversalReason4Choice_> reason,
            IMax105TextXmlAsyncWriter additionalInformation
        )
        {
            this.originator = originator;
            this.reason = reason;
            this.additionalInformation = additionalInformation;
        }
        public async Task WriteAsync(XmlWriter writer, PaymentReversalReason9 valueBeingSerialized, string isoNamespace)
        {
            // Originator Optional PartyIdentification135 PartyIdentification135
            if ( valueBeingSerialized.Originator is PartyIdentification135 populatedOriginator)
            {
                await writer.WriteStartElementAsync(null, "Orgtr", isoNamespace );
                await originator.WriteAsync(writer, populatedOriginator, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Reason Optional ReversalReason4Choice ReversalReason4Choice_
            if ( valueBeingSerialized.Reason is ReversalReason4Choice_ populatedReason)
            {
                await writer.WriteStartElementAsync(null, "Rsn", isoNamespace );
                await reason.WriteAsync(writer, populatedReason, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // AdditionalInformation Optional Max105Text System.String
            if ( valueBeingSerialized.AdditionalInformation is System.String populatedAdditionalInformation)
            {
                await writer.WriteStartElementAsync(null, "AddtlInf", isoNamespace );
                await additionalInformation.WriteAsync(writer, populatedAdditionalInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
