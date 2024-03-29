﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AmountSerializationGenerator for RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount.  ISO2002 ID# _WOMlp9p-Ed-ak6NoX_4Aeg_-1678737059.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount"/>.
    /// </summary>
    public class RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmountXmlAsyncWriter : ISubordinateXmlAsyncWriter<RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount>
    {
        public async Task WriteAsync(XmlWriter writer, RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount valueBeingSerialized, string isoNamespace)
        {
            await writer.WriteAttributeStringAsync( null, "Currency", isoNamespace, valueBeingSerialized.Currency.ToString() );
            await writer.WriteStringAsync( valueBeingSerialized.Amount.ToString());
        }
    }
}
