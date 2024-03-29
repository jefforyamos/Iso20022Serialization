﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetSerializationGenerator for PaymentMethod4Code.  ISO2002 ID# _Z0kPYdp-Ed-ak6NoX_4Aeg_-2121115820.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Codesets
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="PaymentMethod4Code"/>.
    /// </summary>
    public class PaymentMethod4CodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<PaymentMethod4Code>
    {
        public virtual async Task WriteAsync(XmlWriter writer, PaymentMethod4Code valueBeingSerialized, string isoNamespace)
        {
            var valueToWrite = valueBeingSerialized switch
            {
                PaymentMethod4Code.Cheque => "CHK",
                PaymentMethod4Code.CreditTransfer => "TRF",
                PaymentMethod4Code.DirectDebit => "DD",
                PaymentMethod4Code.TransferAdvice => "TRA",
                _ => "_"
            };
            await writer.WriteStringAsync(valueToWrite);
        }
    }
}
