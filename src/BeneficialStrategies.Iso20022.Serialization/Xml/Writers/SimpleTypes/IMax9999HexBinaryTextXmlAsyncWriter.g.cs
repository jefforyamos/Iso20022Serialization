﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceGenerator for Max9999HexBinaryText.  ISO2002 ID# _TwhAATFWEemqWbBf8xprQQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Specifies a character string with a maximum length of 9999 binary bytes (19998 hexadecimal text characters).
    /// 
    /// Used only for hex binary data only, supports only characters A-F and 0-9.
    /// </summary>
    public interface IMax9999HexBinaryTextXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.String>
    {
    }
}