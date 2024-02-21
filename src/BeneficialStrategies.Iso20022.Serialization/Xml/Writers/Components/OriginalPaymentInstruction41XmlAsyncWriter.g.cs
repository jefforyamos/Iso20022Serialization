﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for OriginalPaymentInstruction41.  ISO2002 ID# _b2IDMdcZEeqRFcf2R4bPBw.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="OriginalPaymentInstruction41"/>.
    /// </summary>
    public class OriginalPaymentInstruction41XmlAsyncWriter : ISubordinateXmlAsyncWriter<OriginalPaymentInstruction41>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max35TextXmlAsyncWriter reversalPaymentInformationIdentification;
        private readonly Max35TextXmlAsyncWriter originalPaymentInformationIdentification;
        private readonly Max15NumericTextXmlAsyncWriter originalNumberOfTransactions;
        private readonly DecimalNumberXmlAsyncWriter originalControlSum;
        private readonly BatchBookingIndicatorXmlAsyncWriter batchBooking;
        private readonly TrueFalseIndicatorXmlAsyncWriter paymentInformationReversal;
        private readonly ISubordinateXmlAsyncWriter<PaymentReversalReason9> reversalReasonInformation;
        private readonly ISubordinateXmlAsyncWriter<PaymentTransaction134> transactionInformation;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public OriginalPaymentInstruction41XmlAsyncWriter
        (
            Max35TextXmlAsyncWriter reversalPaymentInformationIdentification,
            Max35TextXmlAsyncWriter originalPaymentInformationIdentification,
            Max15NumericTextXmlAsyncWriter originalNumberOfTransactions,
            DecimalNumberXmlAsyncWriter originalControlSum,
            BatchBookingIndicatorXmlAsyncWriter batchBooking,
            TrueFalseIndicatorXmlAsyncWriter paymentInformationReversal,
            ISubordinateXmlAsyncWriter<PaymentReversalReason9> reversalReasonInformation,
            ISubordinateXmlAsyncWriter<PaymentTransaction134> transactionInformation
        )
        {
            this.reversalPaymentInformationIdentification = reversalPaymentInformationIdentification;
            this.originalPaymentInformationIdentification = originalPaymentInformationIdentification;
            this.originalNumberOfTransactions = originalNumberOfTransactions;
            this.originalControlSum = originalControlSum;
            this.batchBooking = batchBooking;
            this.paymentInformationReversal = paymentInformationReversal;
            this.reversalReasonInformation = reversalReasonInformation;
            this.transactionInformation = transactionInformation;
        }
        public async Task WriteAsync(XmlWriter writer, OriginalPaymentInstruction41 valueBeingSerialized, string isoNamespace)
        {
            // ReversalPaymentInformationIdentification Optional Max35Text System.String
            if ( valueBeingSerialized.ReversalPaymentInformationIdentification is System.String populatedReversalPaymentInformationIdentification)
            {
                await writer.WriteStartElementAsync(null, "RvslPmtInfId", isoNamespace );
                await reversalPaymentInformationIdentification.WriteAsync(writer, populatedReversalPaymentInformationIdentification, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // OriginalPaymentInformationIdentification Required Max35Text System.String
            await writer.WriteStartElementAsync(null, "OrgnlPmtInfId", isoNamespace );
            await originalPaymentInformationIdentification.WriteAsync(writer, valueBeingSerialized.OriginalPaymentInformationIdentification, isoNamespace);
            await writer.WriteEndElementAsync();
            // OriginalNumberOfTransactions Optional Max15NumericText System.String
            if ( valueBeingSerialized.OriginalNumberOfTransactions is System.String populatedOriginalNumberOfTransactions)
            {
                await writer.WriteStartElementAsync(null, "OrgnlNbOfTxs", isoNamespace );
                await originalNumberOfTransactions.WriteAsync(writer, populatedOriginalNumberOfTransactions, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // OriginalControlSum Optional DecimalNumber System.UInt64
            if ( valueBeingSerialized.OriginalControlSum is System.UInt64 populatedOriginalControlSum)
            {
                await writer.WriteStartElementAsync(null, "OrgnlCtrlSum", isoNamespace );
                await originalControlSum.WriteAsync(writer, populatedOriginalControlSum, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // BatchBooking Optional BatchBookingIndicator System.String
            if ( valueBeingSerialized.BatchBooking is System.String populatedBatchBooking)
            {
                await writer.WriteStartElementAsync(null, "BtchBookg", isoNamespace );
                await batchBooking.WriteAsync(writer, populatedBatchBooking, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // PaymentInformationReversal Optional TrueFalseIndicator System.String
            if ( valueBeingSerialized.PaymentInformationReversal is System.String populatedPaymentInformationReversal)
            {
                await writer.WriteStartElementAsync(null, "PmtInfRvsl", isoNamespace );
                await paymentInformationReversal.WriteAsync(writer, populatedPaymentInformationReversal, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // ReversalReasonInformation Optional PaymentReversalReason9 PaymentReversalReason9
            if ( valueBeingSerialized.ReversalReasonInformation is PaymentReversalReason9 populatedReversalReasonInformation)
            {
                await writer.WriteStartElementAsync(null, "RvslRsnInf", isoNamespace );
                await reversalReasonInformation.WriteAsync(writer, populatedReversalReasonInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // TransactionInformation Optional PaymentTransaction134 PaymentTransaction134
            if ( valueBeingSerialized.TransactionInformation is PaymentTransaction134 populatedTransactionInformation)
            {
                await writer.WriteStartElementAsync(null, "TxInf", isoNamespace );
                await transactionInformation.WriteAsync(writer, populatedTransactionInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
