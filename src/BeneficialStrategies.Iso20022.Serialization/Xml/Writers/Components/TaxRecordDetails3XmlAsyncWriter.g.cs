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
    public class TaxRecordDetails3XmlAsyncWriter
    ( // primary constructor 
        ISubordinateXmlAsyncWriter<TaxPeriod3> period,
        IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter amount
    ) // end primary constructor
            : ISubordinateXmlAsyncWriter<TaxRecordDetails3>
    {
        public async Task WriteAsync(XmlWriter writer, TaxRecordDetails3 value, string isoNamespace)
        {
            // Period Optional TaxPeriod3 TaxPeriod3
            if ( value.Period is TaxPeriod3 populatedPeriod)
            {
                await writer.WriteStartElementAsync(null, "Prd", isoNamespace );
                await period.WriteAsync(writer, populatedPeriod, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Amount Required ActiveOrHistoricCurrencyAndAmount System.Decimal
            await writer.WriteStartElementAsync(null, "Amt", isoNamespace );
            await amount.WriteAsync(writer, value.Amount, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
