﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceSerializationGenerator for AdviceType1Choice.  ISO2002 ID# _u3TXw9omEembTrt_WixjyQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.AdviceType1Choice;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Choices
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="AdviceType1Choice_"/>.
    /// </summary>
    public class AdviceType1ChoiceXmlAsyncWriter : ISubordinateXmlAsyncWriter<AdviceType1Choice_>
    {
        private readonly AdviceType1ChoiceCodeXmlAsyncWriter code;
        private readonly AdviceType1ChoiceProprietaryXmlAsyncWriter proprietary;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public AdviceType1ChoiceXmlAsyncWriter
        (
            AdviceType1ChoiceCodeXmlAsyncWriter code,
            AdviceType1ChoiceProprietaryXmlAsyncWriter proprietary
        )
        {
            this.code = code;
            this.proprietary = proprietary;
        }
        public Task WriteAsync(XmlWriter writer, AdviceType1Choice_ valueBeingSerialized, string isoNamespace)
        {
            return valueBeingSerialized switch
            {
                BeneficialStrategies.Iso20022.Choices.AdviceType1Choice.Code _code => this.code.WriteAsync( writer, _code, isoNamespace ),
                BeneficialStrategies.Iso20022.Choices.AdviceType1Choice.Proprietary _proprietary => this.proprietary.WriteAsync( writer, _proprietary, isoNamespace ),
                _ => throw new InvalidCastException( $"Data type of {valueBeingSerialized.GetType().FullName} has no corresponding serializer.")
            };
        }
    }
}
