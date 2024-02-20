﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceGenerator for ActiveOrHistoricCurrencyAnd13DecimalAmount.  ISO2002 ID# _YYB_9Np-Ed-ak6NoX_4Aeg_-771372619.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// A number of monetary units specified in an active or a historic currency where the unit of currency is explicit and compliant with ISO 4217. The number of fractional digits (or minor unit of currency) is not checked as per ISO 4217: It must be lesser than or equal to 13.|Note: The decimal separator is a dot.
    /// </summary>
    public interface IActiveOrHistoricCurrencyAnd13DecimalAmountXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.Decimal>
    {
    }
}
