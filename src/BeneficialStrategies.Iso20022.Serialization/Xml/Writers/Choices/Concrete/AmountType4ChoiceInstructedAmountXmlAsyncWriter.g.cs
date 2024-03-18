﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for InstructedAmount.  ISO2002 ID# __k-HA1kJEeSeLKjZh_lWZw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AmountType4Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

using InstructedAmount = BeneficialStrategies.Iso20022.Choices.AmountType4Choice.InstructedAmount;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.AmountType4Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="InstructedAmount"/>.
    /// Serialization is specific to amount type ActiveOrHistoricCurrencyAndAmount.
    /// </summary>
    public class AmountType4ChoiceInstructedAmountXmlAsyncWriter : ISubordinateXmlAsyncWriter<InstructedAmount>
    {
        public async Task WriteAsync(XmlWriter writer, InstructedAmount valueBeingSerialized, string isoNamespace)
        {
            await writer.WriteStartElementAsync( null, "InstdAmt", isoNamespace );
            await writer.WriteAttributeStringAsync( null, "Ccy", null, valueBeingSerialized.Currency.ToString() );
            await writer.WriteStringAsync( valueBeingSerialized.Amount.ToString());
            await writer.WriteEndElementAsync();
        }
    }
}
