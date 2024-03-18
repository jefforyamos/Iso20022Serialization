﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AmountSerializationGenerator for CurrencyAnd30Amount.  ISO2002 ID# _L8ZcEp0gEeOo48XfssNw8w.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="CurrencyAnd30Amount"/>.
    /// </summary>
    public class CurrencyAnd30AmountXmlAsyncWriter : ISubordinateXmlAsyncWriter<CurrencyAnd30Amount>
    {
        public async Task WriteAsync(XmlWriter writer, CurrencyAnd30Amount valueBeingSerialized, string isoNamespace)
        {
            await writer.WriteAttributeStringAsync( null, "Currency", isoNamespace, valueBeingSerialized.Currency.ToString() );
            await writer.WriteStringAsync( valueBeingSerialized.Amount.ToString());
        }
    }
}
