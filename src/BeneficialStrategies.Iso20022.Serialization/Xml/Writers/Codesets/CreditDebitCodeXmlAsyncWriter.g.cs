﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetSerializationGenerator for CreditDebitCode.  ISO2002 ID# _bTfEdtp-Ed-ak6NoX_4Aeg_826087773.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Codesets
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="CreditDebitCode"/>.
    /// </summary>
    public class CreditDebitCodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<CreditDebitCode>
    {
        public virtual async Task WriteAsync(XmlWriter writer, CreditDebitCode valueBeingSerialized, string isoNamespace)
        {
            var valueToWrite = valueBeingSerialized switch
            {
                CreditDebitCode.Credit => "CRDT",
                CreditDebitCode.Debit => "DBIT",
                _ => "_"
            };
            await writer.WriteStringAsync(valueToWrite);
        }
    }
}