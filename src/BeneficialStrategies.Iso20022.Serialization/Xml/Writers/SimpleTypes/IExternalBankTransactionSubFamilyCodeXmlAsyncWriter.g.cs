﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceForExternalCodesetsGenerator for ExternalBankTransactionSubFamilyCode.  ISO2002 ID# _amVqkdp-Ed-ak6NoX_4Aeg_-1376829537.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Specifies the external sub-family code of the bank transaction code in the format of character string with a maximum length of 4 characters.
    /// The list of valid codes is an external code list published separately, and is a sub-list of the bank transaction family code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    public interface IExternalBankTransactionSubFamilyCodeXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.String>
    {
    }
}
