﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceForExternalCodesetsGenerator for ISO8583TransactionTypeCode.  ISO2002 ID# _dup0QMr_EeuNe7RtB4qFHw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Code which indicates the type of transaction being undertaken (ISO 8583, Transaction type codes).  The code is checked against the list of transaction types coded with two alpha-numeric characters, defined in the standard.
    /// </summary>
    public interface IISO8583TransactionTypeCodeXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.String>
    {
    }
}
