﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceGenerator for RestrictedFINMax23Text.  ISO2002 ID# _WN5DqNp-Ed-ak6NoX_4Aeg_-191272700.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Specifies a character string with a maximum length of 23 characters. It has a pattern ([^/]+/)+([^/]+)|([^/]*) that disables the use of slash &quot;/&quot; at the beginning and end of line and double slash &quot;//&quot; within the line.
    /// </summary>
    public interface IRestrictedFINMax23TextXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.String>
    {
    }
}
