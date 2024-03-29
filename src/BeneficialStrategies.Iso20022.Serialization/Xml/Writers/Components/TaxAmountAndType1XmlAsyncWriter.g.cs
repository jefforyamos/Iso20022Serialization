﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for TaxAmountAndType1.  ISO2002 ID# _ts1L0VkyEeGeoaLUQk__nA_404730048.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="TaxAmountAndType1"/>.
    /// </summary>
    public class TaxAmountAndType1XmlAsyncWriter : ISubordinateXmlAsyncWriter<TaxAmountAndType1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<TaxAmountType1Choice_> type;
        private readonly ISubordinateXmlAsyncWriter<ActiveOrHistoricCurrencyAndAmount> amount;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public TaxAmountAndType1XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<TaxAmountType1Choice_> type,
            ISubordinateXmlAsyncWriter<ActiveOrHistoricCurrencyAndAmount> amount
        )
        {
            this.type = type;
            this.amount = amount;
        }
        public async Task WriteAsync(XmlWriter writer, TaxAmountAndType1 valueBeingSerialized, string isoNamespace)
        {
            // Type Optional TaxAmountType1Choice TaxAmountType1Choice_
            if ( valueBeingSerialized.Type is TaxAmountType1Choice_ populatedType)
            {
                await writer.WriteStartElementAsync(null, "Tp", isoNamespace );
                await type.WriteAsync(writer, populatedType, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Amount Required ActiveOrHistoricCurrencyAndAmount ActiveOrHistoricCurrencyAndAmount
            await writer.WriteStartElementAsync(null, "Amt", isoNamespace );
            await amount.WriteAsync(writer, valueBeingSerialized.Amount, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
