﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceSerializationGenerator for DiscountAmountType1Choice.  ISO2002 ID# _tlhp9FkyEeGeoaLUQk__nA_1969856985.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.DiscountAmountType1Choice;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Choices
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="DiscountAmountType1Choice_"/>.
    /// </summary>
    public class DiscountAmountType1ChoiceXmlAsyncWriter : ISubordinateXmlAsyncWriter<DiscountAmountType1Choice_>
    {
        private readonly DiscountAmountType1ChoiceCodeXmlAsyncWriter code;
        private readonly DiscountAmountType1ChoiceProprietaryXmlAsyncWriter proprietary;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public DiscountAmountType1ChoiceXmlAsyncWriter
        (
            DiscountAmountType1ChoiceCodeXmlAsyncWriter code,
            DiscountAmountType1ChoiceProprietaryXmlAsyncWriter proprietary
        )
        {
            this.code = code;
            this.proprietary = proprietary;
        }
        public Task WriteAsync(XmlWriter writer, DiscountAmountType1Choice_ valueBeingSerialized, string isoNamespace)
        {
            return valueBeingSerialized switch
            {
                BeneficialStrategies.Iso20022.Choices.DiscountAmountType1Choice.Code _code => this.code.WriteAsync( writer, _code, isoNamespace ),
                BeneficialStrategies.Iso20022.Choices.DiscountAmountType1Choice.Proprietary _proprietary => this.proprietary.WriteAsync( writer, _proprietary, isoNamespace ),
                _ => throw new InvalidCastException( $"Data type of {valueBeingSerialized.GetType().FullName} has no corresponding serializer.")
            };
        }
    }
}
