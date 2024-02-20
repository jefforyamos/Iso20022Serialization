﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceGenerator for Max30DecimalNumber.  ISO2002 ID# _xNcaMBrKEeyhRdHRjakS2w.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Number of objects represented as a decimal number, for example 0.75 or 45.6 with a maximum of 30 digits and 29 fraction digits.
    /// </summary>
    public interface IMax30DecimalNumberXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.UInt64>
    {
    }
}
