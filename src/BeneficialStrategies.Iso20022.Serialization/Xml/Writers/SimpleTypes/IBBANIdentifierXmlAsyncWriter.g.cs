﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceGenerator for BBANIdentifier.  ISO2002 ID# _YWr8Jtp-Ed-ak6NoX_4Aeg_-1329929778.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Basic Bank Account Number (BBAN). Identifier used nationally by financial institutions, ie, in individual countries, generally as part of a National Account Numbering Scheme(s), which uniquely identifies the account of a customer.
    /// </summary>
    public interface IBBANIdentifierXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.String>
    {
    }
}