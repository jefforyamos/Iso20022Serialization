﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetSerializationGenerator for ExternalCreditorAgentInstruction1Code.  ISO2002 ID# _gVopcMP-Eemsic1bQcEtLA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Codesets
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="ExternalCreditorAgentInstruction1Code"/>.
    /// </summary>
    public class ExternalCreditorAgentInstruction1CodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<ExternalCreditorAgentInstruction1Code>
    {
        public virtual async Task WriteAsync(XmlWriter writer, ExternalCreditorAgentInstruction1Code valueBeingSerialized, string isoNamespace)
        {
            var valueToWrite = valueBeingSerialized switch
            {
                ExternalCreditorAgentInstruction1Code.PayCreditorByCheque => "CHQB",
                ExternalCreditorAgentInstruction1Code.HoldCashForCreditor => "HOLD",
                ExternalCreditorAgentInstruction1Code.PhoneBeneficiary => "PHOB",
                ExternalCreditorAgentInstruction1Code.PayerTokenRequested => "PRTK",
                ExternalCreditorAgentInstruction1Code.ReceiverCustomerInformation => "RECI",
                ExternalCreditorAgentInstruction1Code.Telecom => "TELB",
                ExternalCreditorAgentInstruction1Code.TokenCounterpartyMismatch => "TKCM",
                ExternalCreditorAgentInstruction1Code.TokenSingleUse => "TKSG",
                ExternalCreditorAgentInstruction1Code.TokenSuspended => "TKSP",
                ExternalCreditorAgentInstruction1Code.TokenValueLimitExceeded => "TKVE",
                ExternalCreditorAgentInstruction1Code.TokenExpired => "TKXP",
                ExternalCreditorAgentInstruction1Code.Token => "TOKN",
                ExternalCreditorAgentInstruction1Code.TokenValidation => "VLTK",
                _ => "_"
            };
            await writer.WriteStringAsync(valueToWrite);
        }
    }
}
