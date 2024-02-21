﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for TaxRecordDetails3.  ISO2002 ID# _oAWcqd4lEeqt1ZcLzWyWFw.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="TaxRecordDetails3"/>.
    /// </summary>
    public class TaxRecordDetails3XmlAsyncWriter : ISubordinateXmlAsyncWriter<TaxRecordDetails3>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<TaxPeriod3> period;
        private readonly ActiveOrHistoricCurrencyAndAmountXmlAsyncWriter amount;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public TaxRecordDetails3XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<TaxPeriod3> period,
            ActiveOrHistoricCurrencyAndAmountXmlAsyncWriter amount
        )
        {
            this.period = period;
            this.amount = amount;
        }
        public async Task WriteAsync(XmlWriter writer, TaxRecordDetails3 valueBeingSerialized, string isoNamespace)
        {
            // Period Optional TaxPeriod3 TaxPeriod3
            if ( valueBeingSerialized.Period is TaxPeriod3 populatedPeriod)
            {
                await writer.WriteStartElementAsync(null, "Prd", isoNamespace );
                await period.WriteAsync(writer, populatedPeriod, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Amount Required ActiveOrHistoricCurrencyAndAmount System.Decimal
            await writer.WriteStartElementAsync(null, "Amt", isoNamespace );
            await amount.WriteAsync(writer, valueBeingSerialized.Amount, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
