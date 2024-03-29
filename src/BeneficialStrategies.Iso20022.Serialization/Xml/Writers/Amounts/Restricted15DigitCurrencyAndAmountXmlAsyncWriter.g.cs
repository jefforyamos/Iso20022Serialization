﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AmountSerializationGenerator for Restricted15DigitCurrencyAndAmount.  ISO2002 ID# _hldkIFmsEea0TrLY-ZieOg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Amounts
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Restricted15DigitCurrencyAndAmount"/>.
    /// </summary>
    public class Restricted15DigitCurrencyAndAmountXmlAsyncWriter : ISubordinateXmlAsyncWriter<Restricted15DigitCurrencyAndAmount>
    {
        public async Task WriteAsync(XmlWriter writer, Restricted15DigitCurrencyAndAmount valueBeingSerialized, string isoNamespace)
        {
            await writer.WriteAttributeStringAsync( null, "Currency", isoNamespace, valueBeingSerialized.Currency.ToString() );
            await writer.WriteStringAsync( valueBeingSerialized.Amount.ToString());
        }
    }
}
