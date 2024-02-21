﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for DocumentAdjustment1.  ISO2002 ID# _UP-lctp-Ed-ak6NoX_4Aeg_1188294125.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Components
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="DocumentAdjustment1"/>.
    /// </summary>
    public class DocumentAdjustment1XmlAsyncWriter : ISubordinateXmlAsyncWriter<DocumentAdjustment1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ActiveOrHistoricCurrencyAndAmountXmlAsyncWriter amount;
        private readonly IEnumXmlAsyncWriter<CreditDebitCode> creditDebitIndicator;
        private readonly Max4TextXmlAsyncWriter reason;
        private readonly Max140TextXmlAsyncWriter additionalInformation;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public DocumentAdjustment1XmlAsyncWriter
        (
            ActiveOrHistoricCurrencyAndAmountXmlAsyncWriter amount,
            IEnumXmlAsyncWriter<CreditDebitCode> creditDebitIndicator,
            Max4TextXmlAsyncWriter reason,
            Max140TextXmlAsyncWriter additionalInformation
        )
        {
            this.amount = amount;
            this.creditDebitIndicator = creditDebitIndicator;
            this.reason = reason;
            this.additionalInformation = additionalInformation;
        }
        public async Task WriteAsync(XmlWriter writer, DocumentAdjustment1 valueBeingSerialized, string isoNamespace)
        {
            // Amount Required ActiveOrHistoricCurrencyAndAmount System.Decimal
            await writer.WriteStartElementAsync(null, "Amt", isoNamespace );
            await amount.WriteAsync(writer, valueBeingSerialized.Amount, isoNamespace);
            await writer.WriteEndElementAsync();
            // CreditDebitIndicator Optional CreditDebitCode CreditDebitCode
            if ( valueBeingSerialized.CreditDebitIndicator is CreditDebitCode populatedCreditDebitIndicator)
            {
                await writer.WriteStartElementAsync(null, "CdtDbtInd", isoNamespace );
                await creditDebitIndicator.WriteAsync(writer, populatedCreditDebitIndicator, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Reason Optional Max4Text System.String
            if ( valueBeingSerialized.Reason is System.String populatedReason)
            {
                await writer.WriteStartElementAsync(null, "Rsn", isoNamespace );
                await reason.WriteAsync(writer, populatedReason, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // AdditionalInformation Optional Max140Text System.String
            if ( valueBeingSerialized.AdditionalInformation is System.String populatedAdditionalInformation)
            {
                await writer.WriteStartElementAsync(null, "AddtlInf", isoNamespace );
                await additionalInformation.WriteAsync(writer, populatedAdditionalInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
