﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceForExternalCodesetsGenerator for ISO8583AmountTypeCode.  ISO2002 ID# _U-BRUCuEEeyg-aG5nXcnfg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Code which identifies the type of amount (ISO 8583, Amount type codes).  The code is checked against the list of amount types coded with two alpha-numeric characters, defined in the standard.
    /// </summary>
    public interface IISO8583AmountTypeCodeXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.String>
    {
    }
}