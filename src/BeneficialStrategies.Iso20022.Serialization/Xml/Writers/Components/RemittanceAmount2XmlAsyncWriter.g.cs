﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for RemittanceAmount2.  ISO2002 ID# _tcu6UlkyEeGeoaLUQk__nA_1720061544.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="RemittanceAmount2"/>.
    /// </summary>
    public class RemittanceAmount2XmlAsyncWriter : ISubordinateXmlAsyncWriter<RemittanceAmount2>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter duePayableAmount;
        private readonly ISubordinateXmlAsyncWriter<DiscountAmountAndType1> discountAppliedAmount;
        private readonly IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter creditNoteAmount;
        private readonly ISubordinateXmlAsyncWriter<TaxAmountAndType1> taxAmount;
        private readonly ISubordinateXmlAsyncWriter<DocumentAdjustment1> adjustmentAmountAndReason;
        private readonly IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter remittedAmount;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public RemittanceAmount2XmlAsyncWriter
        (
            IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter duePayableAmount,
            ISubordinateXmlAsyncWriter<DiscountAmountAndType1> discountAppliedAmount,
            IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter creditNoteAmount,
            ISubordinateXmlAsyncWriter<TaxAmountAndType1> taxAmount,
            ISubordinateXmlAsyncWriter<DocumentAdjustment1> adjustmentAmountAndReason,
            IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter remittedAmount
        )
        {
            this.duePayableAmount = duePayableAmount;
            this.discountAppliedAmount = discountAppliedAmount;
            this.creditNoteAmount = creditNoteAmount;
            this.taxAmount = taxAmount;
            this.adjustmentAmountAndReason = adjustmentAmountAndReason;
            this.remittedAmount = remittedAmount;
        }
        public async Task WriteAsync(XmlWriter writer, RemittanceAmount2 valueBeingSerialized, string isoNamespace)
        {
            // DuePayableAmount Optional ActiveOrHistoricCurrencyAndAmount System.Decimal
            if ( valueBeingSerialized.DuePayableAmount is System.Decimal populatedDuePayableAmount)
            {
                await writer.WriteStartElementAsync(null, "DuePyblAmt", isoNamespace );
                await duePayableAmount.WriteAsync(writer, populatedDuePayableAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // DiscountAppliedAmount Optional DiscountAmountAndType1 DiscountAmountAndType1
            if ( valueBeingSerialized.DiscountAppliedAmount is DiscountAmountAndType1 populatedDiscountAppliedAmount)
            {
                await writer.WriteStartElementAsync(null, "DscntApldAmt", isoNamespace );
                await discountAppliedAmount.WriteAsync(writer, populatedDiscountAppliedAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CreditNoteAmount Optional ActiveOrHistoricCurrencyAndAmount System.Decimal
            if ( valueBeingSerialized.CreditNoteAmount is System.Decimal populatedCreditNoteAmount)
            {
                await writer.WriteStartElementAsync(null, "CdtNoteAmt", isoNamespace );
                await creditNoteAmount.WriteAsync(writer, populatedCreditNoteAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // TaxAmount Optional TaxAmountAndType1 TaxAmountAndType1
            if ( valueBeingSerialized.TaxAmount is TaxAmountAndType1 populatedTaxAmount)
            {
                await writer.WriteStartElementAsync(null, "TaxAmt", isoNamespace );
                await taxAmount.WriteAsync(writer, populatedTaxAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // AdjustmentAmountAndReason Optional DocumentAdjustment1 DocumentAdjustment1
            if ( valueBeingSerialized.AdjustmentAmountAndReason is DocumentAdjustment1 populatedAdjustmentAmountAndReason)
            {
                await writer.WriteStartElementAsync(null, "AdjstmntAmtAndRsn", isoNamespace );
                await adjustmentAmountAndReason.WriteAsync(writer, populatedAdjustmentAmountAndReason, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // RemittedAmount Optional ActiveOrHistoricCurrencyAndAmount System.Decimal
            if ( valueBeingSerialized.RemittedAmount is System.Decimal populatedRemittedAmount)
            {
                await writer.WriteStartElementAsync(null, "RmtdAmt", isoNamespace );
                await remittedAmount.WriteAsync(writer, populatedRemittedAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
