﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AmountSerializationGenerator for ImpliedCurrencyAnd20Amount.  ISO2002 ID# _JG0mceaqEeW1iL_FRZt8bg.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="ImpliedCurrencyAnd20Amount"/>.
    /// </summary>
    public class ImpliedCurrencyAnd20AmountXmlAsyncWriter : ISubordinateXmlAsyncWriter<ImpliedCurrencyAnd20Amount>
    {
        public async Task WriteAsync(XmlWriter writer, ImpliedCurrencyAnd20Amount valueBeingSerialized, string isoNamespace)
        {
            await writer.WriteAttributeStringAsync( null, "Currency", isoNamespace, valueBeingSerialized.Currency.ToString() );
            await writer.WriteStringAsync( valueBeingSerialized.Amount.ToString());
        }
    }
}