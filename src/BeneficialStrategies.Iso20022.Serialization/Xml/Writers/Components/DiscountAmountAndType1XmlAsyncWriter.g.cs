﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for DiscountAmountAndType1.  ISO2002 ID# _tlhp8VkyEeGeoaLUQk__nA_1198616303.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="DiscountAmountAndType1"/>.
    /// </summary>
    public class DiscountAmountAndType1XmlAsyncWriter : ISubordinateXmlAsyncWriter<DiscountAmountAndType1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<DiscountAmountType1Choice_> type;
        private readonly IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter amount;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public DiscountAmountAndType1XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<DiscountAmountType1Choice_> type,
            IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter amount
        )
        {
            this.type = type;
            this.amount = amount;
        }
        public async Task WriteAsync(XmlWriter writer, DiscountAmountAndType1 value, string isoNamespace)
        {
            // Type Optional DiscountAmountType1Choice DiscountAmountType1Choice_
            if ( value.Type is DiscountAmountType1Choice_ populatedType)
            {
                await writer.WriteStartElementAsync(null, "Tp", isoNamespace );
                await type.WriteAsync(writer, populatedType, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Amount Required ActiveOrHistoricCurrencyAndAmount System.Decimal
            await writer.WriteStartElementAsync(null, "Amt", isoNamespace );
            await amount.WriteAsync(writer, value.Amount, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
