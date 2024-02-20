﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceGenerator for ActiveCurrencyAnd24Amount.  ISO2002 ID# _cuFukzTxEemwtJBLtapBmw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217.  It allows up to 24 digits.
    /// </summary>
    public interface IActiveCurrencyAnd24AmountXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.Decimal>
    {
    }
}
