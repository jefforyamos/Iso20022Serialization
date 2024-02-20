﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceGenerator for RestrictedFINImpliedCurrencyAndAmount.  ISO2002 ID# _XZJV1Np-Ed-ak6NoX_4Aeg_681057429.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Number of monetary units specified in a currency where the unit of currency is implied by the context and compliant with ISO 4217. The decimal separator is a dot.|Note: a zero amount is considered a positive amount.
    /// </summary>
    public interface IRestrictedFINImpliedCurrencyAndAmountXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.Decimal>
    {
    }
}
