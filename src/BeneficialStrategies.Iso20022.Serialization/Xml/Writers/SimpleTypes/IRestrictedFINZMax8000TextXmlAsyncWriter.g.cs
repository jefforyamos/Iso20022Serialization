﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceGenerator for RestrictedFINZMax8000Text.  ISO2002 ID# _XZcQwtp-Ed-ak6NoX_4Aeg_-1877082870.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Specifies a character string with a maximum length of 8000 characters limited to character set Z, that is, a-z A-Z / - ? : ( ) . , ‘ += ! “ % &amp; * &lt; &gt; ; @ #  .
    /// </summary>
    public interface IRestrictedFINZMax8000TextXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.String>
    {
    }
}
