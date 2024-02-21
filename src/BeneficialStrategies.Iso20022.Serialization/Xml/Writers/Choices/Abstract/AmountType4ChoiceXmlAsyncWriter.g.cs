﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceSerializationGenerator for AmountType4Choice.  ISO2002 ID# __S0AAVkJEeSeLKjZh_lWZw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AmountType4Choice;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.AmountType4Choice;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Choices
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="AmountType4Choice_"/>.
    /// </summary>
    public class AmountType4ChoiceXmlAsyncWriter : ISubordinateXmlAsyncWriter<AmountType4Choice_>
    {
        private readonly AmountType4ChoiceInstructedAmountXmlAsyncWriter instructedAmount;
        private readonly AmountType4ChoiceEquivalentAmountXmlAsyncWriter equivalentAmount;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public AmountType4ChoiceXmlAsyncWriter
        (
            AmountType4ChoiceInstructedAmountXmlAsyncWriter instructedAmount,
            AmountType4ChoiceEquivalentAmountXmlAsyncWriter equivalentAmount
        )
        {
            this.instructedAmount = instructedAmount;
            this.equivalentAmount = equivalentAmount;
        }
        public Task WriteAsync(XmlWriter writer, AmountType4Choice_ valueBeingSerialized, string isoNamespace)
        {
            return valueBeingSerialized switch
            {
                InstructedAmount _instructedAmount => this.instructedAmount.WriteAsync( writer, _instructedAmount, isoNamespace ),
                EquivalentAmount _equivalentAmount => this.equivalentAmount.WriteAsync( writer, _equivalentAmount, isoNamespace ),
                _ => throw new InvalidCastException( $"Data type of {valueBeingSerialized.GetType().FullName} has no corresponding serializer.")
            };
        }
    }
}