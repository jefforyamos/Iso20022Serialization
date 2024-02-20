﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for TaxInformation10.  ISO2002 ID# _oDl9594lEeqt1ZcLzWyWFw.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="TaxInformation10"/>.
    /// </summary>
    public class TaxInformation10XmlAsyncWriter : ISubordinateXmlAsyncWriter<TaxInformation10>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<TaxParty1> creditor;
        private readonly ISubordinateXmlAsyncWriter<TaxParty2> debtor;
        private readonly IMax35TextXmlAsyncWriter administrationZone;
        private readonly IMax140TextXmlAsyncWriter referenceNumber;
        private readonly IMax35TextXmlAsyncWriter method;
        private readonly IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter totalTaxableBaseAmount;
        private readonly IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter totalTaxAmount;
        private readonly IISODateXmlAsyncWriter date;
        private readonly INumberXmlAsyncWriter sequenceNumber;
        private readonly ISubordinateXmlAsyncWriter<TaxRecord3> record;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public TaxInformation10XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<TaxParty1> creditor,
            ISubordinateXmlAsyncWriter<TaxParty2> debtor,
            IMax35TextXmlAsyncWriter administrationZone,
            IMax140TextXmlAsyncWriter referenceNumber,
            IMax35TextXmlAsyncWriter method,
            IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter totalTaxableBaseAmount,
            IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter totalTaxAmount,
            IISODateXmlAsyncWriter date,
            INumberXmlAsyncWriter sequenceNumber,
            ISubordinateXmlAsyncWriter<TaxRecord3> record
        )
        {
            this.creditor = creditor;
            this.debtor = debtor;
            this.administrationZone = administrationZone;
            this.referenceNumber = referenceNumber;
            this.method = method;
            this.totalTaxableBaseAmount = totalTaxableBaseAmount;
            this.totalTaxAmount = totalTaxAmount;
            this.date = date;
            this.sequenceNumber = sequenceNumber;
            this.record = record;
        }
        public async Task WriteAsync(XmlWriter writer, TaxInformation10 value, string isoNamespace)
        {
            // Creditor Optional TaxParty1 TaxParty1
            if ( value.Creditor is TaxParty1 populatedCreditor)
            {
                await writer.WriteStartElementAsync(null, "Cdtr", isoNamespace );
                await creditor.WriteAsync(writer, populatedCreditor, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Debtor Optional TaxParty2 TaxParty2
            if ( value.Debtor is TaxParty2 populatedDebtor)
            {
                await writer.WriteStartElementAsync(null, "Dbtr", isoNamespace );
                await debtor.WriteAsync(writer, populatedDebtor, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // AdministrationZone Optional Max35Text System.String
            if ( value.AdministrationZone is System.String populatedAdministrationZone)
            {
                await writer.WriteStartElementAsync(null, "AdmstnZone", isoNamespace );
                await administrationZone.WriteAsync(writer, populatedAdministrationZone, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // ReferenceNumber Optional Max140Text System.String
            if ( value.ReferenceNumber is System.String populatedReferenceNumber)
            {
                await writer.WriteStartElementAsync(null, "RefNb", isoNamespace );
                await referenceNumber.WriteAsync(writer, populatedReferenceNumber, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Method Optional Max35Text System.String
            if ( value.Method is System.String populatedMethod)
            {
                await writer.WriteStartElementAsync(null, "Mtd", isoNamespace );
                await method.WriteAsync(writer, populatedMethod, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // TotalTaxableBaseAmount Optional ActiveOrHistoricCurrencyAndAmount System.Decimal
            if ( value.TotalTaxableBaseAmount is System.Decimal populatedTotalTaxableBaseAmount)
            {
                await writer.WriteStartElementAsync(null, "TtlTaxblBaseAmt", isoNamespace );
                await totalTaxableBaseAmount.WriteAsync(writer, populatedTotalTaxableBaseAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // TotalTaxAmount Optional ActiveOrHistoricCurrencyAndAmount System.Decimal
            if ( value.TotalTaxAmount is System.Decimal populatedTotalTaxAmount)
            {
                await writer.WriteStartElementAsync(null, "TtlTaxAmt", isoNamespace );
                await totalTaxAmount.WriteAsync(writer, populatedTotalTaxAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Date Optional ISODate System.DateOnly
            if ( value.Date is System.DateOnly populatedDate)
            {
                await writer.WriteStartElementAsync(null, "Dt", isoNamespace );
                await date.WriteAsync(writer, populatedDate, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // SequenceNumber Optional Number System.UInt64
            if ( value.SequenceNumber is System.UInt64 populatedSequenceNumber)
            {
                await writer.WriteStartElementAsync(null, "SeqNb", isoNamespace );
                await sequenceNumber.WriteAsync(writer, populatedSequenceNumber, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Record Optional TaxRecord3 TaxRecord3
            if ( value.Record is TaxRecord3 populatedRecord)
            {
                await writer.WriteStartElementAsync(null, "Rcrd", isoNamespace );
                await record.WriteAsync(writer, populatedRecord, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}