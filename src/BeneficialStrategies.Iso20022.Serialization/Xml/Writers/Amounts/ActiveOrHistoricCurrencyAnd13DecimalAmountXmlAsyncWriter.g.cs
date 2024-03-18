﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AmountSerializationGenerator for ActiveOrHistoricCurrencyAnd13DecimalAmount.  ISO2002 ID# _YYB_9Np-Ed-ak6NoX_4Aeg_-771372619.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="ActiveOrHistoricCurrencyAnd13DecimalAmount"/>.
    /// </summary>
    public class ActiveOrHistoricCurrencyAnd13DecimalAmountXmlAsyncWriter : ISubordinateXmlAsyncWriter<ActiveOrHistoricCurrencyAnd13DecimalAmount>
    {
        public async Task WriteAsync(XmlWriter writer, ActiveOrHistoricCurrencyAnd13DecimalAmount valueBeingSerialized, string isoNamespace)
        {
            await writer.WriteAttributeStringAsync( null, "Currency", isoNamespace, valueBeingSerialized.Currency.ToString() );
            await writer.WriteStringAsync( valueBeingSerialized.Amount.ToString());
        }
    }
}
