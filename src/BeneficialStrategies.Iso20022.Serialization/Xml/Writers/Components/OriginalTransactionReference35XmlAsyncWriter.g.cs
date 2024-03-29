﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for OriginalTransactionReference35.  ISO2002 ID# _a0FXYdcZEeqRFcf2R4bPBw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Components
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="OriginalTransactionReference35"/>.
    /// </summary>
    public class OriginalTransactionReference35XmlAsyncWriter : ISubordinateXmlAsyncWriter<OriginalTransactionReference35>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<ActiveOrHistoricCurrencyAndAmount> interbankSettlementAmount;
        private readonly ISubordinateXmlAsyncWriter<AmountType4Choice_> amount;
        private readonly ISODateXmlAsyncWriter interbankSettlementDate;
        private readonly ISODateXmlAsyncWriter requestedCollectionDate;
        private readonly ISubordinateXmlAsyncWriter<DateAndDateTime2Choice_> requestedExecutionDate;
        private readonly ISubordinateXmlAsyncWriter<PartyIdentification135> creditorSchemeIdentification;
        private readonly ISubordinateXmlAsyncWriter<SettlementInstruction11> settlementInformation;
        private readonly ISubordinateXmlAsyncWriter<PaymentTypeInformation27> paymentTypeInformation;
        private readonly PaymentMethod4CodeXmlAsyncWriter paymentMethod;
        private readonly ISubordinateXmlAsyncWriter<MandateRelatedData2Choice_> mandateRelatedInformation;
        private readonly ISubordinateXmlAsyncWriter<RemittanceInformation21> remittanceInformation;
        private readonly ISubordinateXmlAsyncWriter<Party40Choice_> ultimateDebtor;
        private readonly ISubordinateXmlAsyncWriter<Party40Choice_> debtor;
        private readonly ISubordinateXmlAsyncWriter<CashAccount40> debtorAccount;
        private readonly ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> debtorAgent;
        private readonly ISubordinateXmlAsyncWriter<CashAccount40> debtorAgentAccount;
        private readonly ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> creditorAgent;
        private readonly ISubordinateXmlAsyncWriter<CashAccount40> creditorAgentAccount;
        private readonly ISubordinateXmlAsyncWriter<Party40Choice_> creditor;
        private readonly ISubordinateXmlAsyncWriter<CashAccount40> creditorAccount;
        private readonly ISubordinateXmlAsyncWriter<Party40Choice_> ultimateCreditor;
        private readonly ISubordinateXmlAsyncWriter<Purpose2Choice_> purpose;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public OriginalTransactionReference35XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<ActiveOrHistoricCurrencyAndAmount> interbankSettlementAmount,
            ISubordinateXmlAsyncWriter<AmountType4Choice_> amount,
            ISODateXmlAsyncWriter interbankSettlementDate,
            ISODateXmlAsyncWriter requestedCollectionDate,
            ISubordinateXmlAsyncWriter<DateAndDateTime2Choice_> requestedExecutionDate,
            ISubordinateXmlAsyncWriter<PartyIdentification135> creditorSchemeIdentification,
            ISubordinateXmlAsyncWriter<SettlementInstruction11> settlementInformation,
            ISubordinateXmlAsyncWriter<PaymentTypeInformation27> paymentTypeInformation,
            PaymentMethod4CodeXmlAsyncWriter paymentMethod,
            ISubordinateXmlAsyncWriter<MandateRelatedData2Choice_> mandateRelatedInformation,
            ISubordinateXmlAsyncWriter<RemittanceInformation21> remittanceInformation,
            ISubordinateXmlAsyncWriter<Party40Choice_> ultimateDebtor,
            ISubordinateXmlAsyncWriter<Party40Choice_> debtor,
            ISubordinateXmlAsyncWriter<CashAccount40> debtorAccount,
            ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> debtorAgent,
            ISubordinateXmlAsyncWriter<CashAccount40> debtorAgentAccount,
            ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> creditorAgent,
            ISubordinateXmlAsyncWriter<CashAccount40> creditorAgentAccount,
            ISubordinateXmlAsyncWriter<Party40Choice_> creditor,
            ISubordinateXmlAsyncWriter<CashAccount40> creditorAccount,
            ISubordinateXmlAsyncWriter<Party40Choice_> ultimateCreditor,
            ISubordinateXmlAsyncWriter<Purpose2Choice_> purpose
        )
        {
            this.interbankSettlementAmount = interbankSettlementAmount;
            this.amount = amount;
            this.interbankSettlementDate = interbankSettlementDate;
            this.requestedCollectionDate = requestedCollectionDate;
            this.requestedExecutionDate = requestedExecutionDate;
            this.creditorSchemeIdentification = creditorSchemeIdentification;
            this.settlementInformation = settlementInformation;
            this.paymentTypeInformation = paymentTypeInformation;
            this.paymentMethod = paymentMethod;
            this.mandateRelatedInformation = mandateRelatedInformation;
            this.remittanceInformation = remittanceInformation;
            this.ultimateDebtor = ultimateDebtor;
            this.debtor = debtor;
            this.debtorAccount = debtorAccount;
            this.debtorAgent = debtorAgent;
            this.debtorAgentAccount = debtorAgentAccount;
            this.creditorAgent = creditorAgent;
            this.creditorAgentAccount = creditorAgentAccount;
            this.creditor = creditor;
            this.creditorAccount = creditorAccount;
            this.ultimateCreditor = ultimateCreditor;
            this.purpose = purpose;
        }
        public async Task WriteAsync(XmlWriter writer, OriginalTransactionReference35 valueBeingSerialized, string isoNamespace)
        {
            // InterbankSettlementAmount Optional ActiveOrHistoricCurrencyAndAmount ActiveOrHistoricCurrencyAndAmount
            if ( valueBeingSerialized.InterbankSettlementAmount is ActiveOrHistoricCurrencyAndAmount populatedInterbankSettlementAmount)
            {
                await writer.WriteStartElementAsync(null, "IntrBkSttlmAmt", isoNamespace );
                await interbankSettlementAmount.WriteAsync(writer, populatedInterbankSettlementAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Amount Optional AmountType4Choice AmountType4Choice_
            if ( valueBeingSerialized.Amount is AmountType4Choice_ populatedAmount)
            {
                await writer.WriteStartElementAsync(null, "Amt", isoNamespace );
                await amount.WriteAsync(writer, populatedAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // InterbankSettlementDate Optional ISODate System.DateOnly
            if ( valueBeingSerialized.InterbankSettlementDate is System.DateOnly populatedInterbankSettlementDate)
            {
                await writer.WriteStartElementAsync(null, "IntrBkSttlmDt", isoNamespace );
                await interbankSettlementDate.WriteAsync(writer, populatedInterbankSettlementDate, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // RequestedCollectionDate Optional ISODate System.DateOnly
            if ( valueBeingSerialized.RequestedCollectionDate is System.DateOnly populatedRequestedCollectionDate)
            {
                await writer.WriteStartElementAsync(null, "ReqdColltnDt", isoNamespace );
                await requestedCollectionDate.WriteAsync(writer, populatedRequestedCollectionDate, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // RequestedExecutionDate Optional DateAndDateTime2Choice DateAndDateTime2Choice_
            if ( valueBeingSerialized.RequestedExecutionDate is DateAndDateTime2Choice_ populatedRequestedExecutionDate)
            {
                await writer.WriteStartElementAsync(null, "ReqdExctnDt", isoNamespace );
                await requestedExecutionDate.WriteAsync(writer, populatedRequestedExecutionDate, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CreditorSchemeIdentification Optional PartyIdentification135 PartyIdentification135
            if ( valueBeingSerialized.CreditorSchemeIdentification is PartyIdentification135 populatedCreditorSchemeIdentification)
            {
                await writer.WriteStartElementAsync(null, "CdtrSchmeId", isoNamespace );
                await creditorSchemeIdentification.WriteAsync(writer, populatedCreditorSchemeIdentification, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // SettlementInformation Optional SettlementInstruction11 SettlementInstruction11
            if ( valueBeingSerialized.SettlementInformation is SettlementInstruction11 populatedSettlementInformation)
            {
                await writer.WriteStartElementAsync(null, "SttlmInf", isoNamespace );
                await settlementInformation.WriteAsync(writer, populatedSettlementInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // PaymentTypeInformation Optional PaymentTypeInformation27 PaymentTypeInformation27
            if ( valueBeingSerialized.PaymentTypeInformation is PaymentTypeInformation27 populatedPaymentTypeInformation)
            {
                await writer.WriteStartElementAsync(null, "PmtTpInf", isoNamespace );
                await paymentTypeInformation.WriteAsync(writer, populatedPaymentTypeInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // PaymentMethod Optional PaymentMethod4Code PaymentMethod4Code
            if ( valueBeingSerialized.PaymentMethod is PaymentMethod4Code populatedPaymentMethod)
            {
                await writer.WriteStartElementAsync(null, "PmtMtd", isoNamespace );
                await paymentMethod.WriteAsync(writer, populatedPaymentMethod, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // MandateRelatedInformation Optional MandateRelatedData2Choice MandateRelatedData2Choice_
            if ( valueBeingSerialized.MandateRelatedInformation is MandateRelatedData2Choice_ populatedMandateRelatedInformation)
            {
                await writer.WriteStartElementAsync(null, "MndtRltdInf", isoNamespace );
                await mandateRelatedInformation.WriteAsync(writer, populatedMandateRelatedInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // RemittanceInformation Optional RemittanceInformation21 RemittanceInformation21
            if ( valueBeingSerialized.RemittanceInformation is RemittanceInformation21 populatedRemittanceInformation)
            {
                await writer.WriteStartElementAsync(null, "RmtInf", isoNamespace );
                await remittanceInformation.WriteAsync(writer, populatedRemittanceInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // UltimateDebtor Optional Party40Choice Party40Choice_
            if ( valueBeingSerialized.UltimateDebtor is Party40Choice_ populatedUltimateDebtor)
            {
                await writer.WriteStartElementAsync(null, "UltmtDbtr", isoNamespace );
                await ultimateDebtor.WriteAsync(writer, populatedUltimateDebtor, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Debtor Optional Party40Choice Party40Choice_
            if ( valueBeingSerialized.Debtor is Party40Choice_ populatedDebtor)
            {
                await writer.WriteStartElementAsync(null, "Dbtr", isoNamespace );
                await debtor.WriteAsync(writer, populatedDebtor, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // DebtorAccount Optional CashAccount40 CashAccount40
            if ( valueBeingSerialized.DebtorAccount is CashAccount40 populatedDebtorAccount)
            {
                await writer.WriteStartElementAsync(null, "DbtrAcct", isoNamespace );
                await debtorAccount.WriteAsync(writer, populatedDebtorAccount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // DebtorAgent Optional BranchAndFinancialInstitutionIdentification6 BranchAndFinancialInstitutionIdentification6
            if ( valueBeingSerialized.DebtorAgent is BranchAndFinancialInstitutionIdentification6 populatedDebtorAgent)
            {
                await writer.WriteStartElementAsync(null, "DbtrAgt", isoNamespace );
                await debtorAgent.WriteAsync(writer, populatedDebtorAgent, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // DebtorAgentAccount Optional CashAccount40 CashAccount40
            if ( valueBeingSerialized.DebtorAgentAccount is CashAccount40 populatedDebtorAgentAccount)
            {
                await writer.WriteStartElementAsync(null, "DbtrAgtAcct", isoNamespace );
                await debtorAgentAccount.WriteAsync(writer, populatedDebtorAgentAccount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CreditorAgent Optional BranchAndFinancialInstitutionIdentification6 BranchAndFinancialInstitutionIdentification6
            if ( valueBeingSerialized.CreditorAgent is BranchAndFinancialInstitutionIdentification6 populatedCreditorAgent)
            {
                await writer.WriteStartElementAsync(null, "CdtrAgt", isoNamespace );
                await creditorAgent.WriteAsync(writer, populatedCreditorAgent, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CreditorAgentAccount Optional CashAccount40 CashAccount40
            if ( valueBeingSerialized.CreditorAgentAccount is CashAccount40 populatedCreditorAgentAccount)
            {
                await writer.WriteStartElementAsync(null, "CdtrAgtAcct", isoNamespace );
                await creditorAgentAccount.WriteAsync(writer, populatedCreditorAgentAccount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Creditor Optional Party40Choice Party40Choice_
            if ( valueBeingSerialized.Creditor is Party40Choice_ populatedCreditor)
            {
                await writer.WriteStartElementAsync(null, "Cdtr", isoNamespace );
                await creditor.WriteAsync(writer, populatedCreditor, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CreditorAccount Optional CashAccount40 CashAccount40
            if ( valueBeingSerialized.CreditorAccount is CashAccount40 populatedCreditorAccount)
            {
                await writer.WriteStartElementAsync(null, "CdtrAcct", isoNamespace );
                await creditorAccount.WriteAsync(writer, populatedCreditorAccount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // UltimateCreditor Optional Party40Choice Party40Choice_
            if ( valueBeingSerialized.UltimateCreditor is Party40Choice_ populatedUltimateCreditor)
            {
                await writer.WriteStartElementAsync(null, "UltmtCdtr", isoNamespace );
                await ultimateCreditor.WriteAsync(writer, populatedUltimateCreditor, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Purpose Optional Purpose2Choice Purpose2Choice_
            if ( valueBeingSerialized.Purpose is Purpose2Choice_ populatedPurpose)
            {
                await writer.WriteStartElementAsync(null, "Purp", isoNamespace );
                await purpose.WriteAsync(writer, populatedPurpose, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
