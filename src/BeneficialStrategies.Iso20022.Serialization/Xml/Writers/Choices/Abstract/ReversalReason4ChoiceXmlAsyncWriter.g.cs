﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceSerializationGenerator for ReversalReason4Choice.  ISO2002 ID# _TQ8xYNp-Ed-ak6NoX_4Aeg_-340627899.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.ReversalReason4Choice;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Choices
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="ReversalReason4Choice_"/>.
    /// </summary>
    public class ReversalReason4ChoiceXmlAsyncWriter : ISubordinateXmlAsyncWriter<ReversalReason4Choice_>
    {
        private readonly ReversalReason4ChoiceCodeXmlAsyncWriter code;
        private readonly ReversalReason4ChoiceProprietaryXmlAsyncWriter proprietary;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public ReversalReason4ChoiceXmlAsyncWriter
        (
            ReversalReason4ChoiceCodeXmlAsyncWriter code,
            ReversalReason4ChoiceProprietaryXmlAsyncWriter proprietary
        )
        {
            this.code = code;
            this.proprietary = proprietary;
        }
        public Task WriteAsync(XmlWriter writer, ReversalReason4Choice_ valueBeingSerialized, string isoNamespace)
        {
            return valueBeingSerialized switch
            {
                Code _code => this.code.WriteAsync( writer, _code, isoNamespace ),
                Proprietary _proprietary => this.proprietary.WriteAsync( writer, _proprietary, isoNamespace ),
                _ => throw new InvalidCastException( $"Data type of {valueBeingSerialized.GetType().FullName} has no corresponding serializer.")
            };
        }
    }
}
