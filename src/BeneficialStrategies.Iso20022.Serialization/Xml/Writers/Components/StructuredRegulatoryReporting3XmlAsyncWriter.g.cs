﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for StructuredRegulatoryReporting3.  ISO2002 ID# _SnhZ4tp-Ed-ak6NoX_4Aeg_797411932.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="StructuredRegulatoryReporting3"/>.
    /// </summary>
    public class StructuredRegulatoryReporting3XmlAsyncWriter : ISubordinateXmlAsyncWriter<StructuredRegulatoryReporting3>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IMax35TextXmlAsyncWriter type;
        private readonly IISODateXmlAsyncWriter date;
        private readonly ICountryCodeXmlAsyncWriter country;
        private readonly IMax10TextXmlAsyncWriter code;
        private readonly IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter amount;
        private readonly IMax35TextXmlAsyncWriter information;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public StructuredRegulatoryReporting3XmlAsyncWriter
        (
            IMax35TextXmlAsyncWriter type,
            IISODateXmlAsyncWriter date,
            ICountryCodeXmlAsyncWriter country,
            IMax10TextXmlAsyncWriter code,
            IActiveOrHistoricCurrencyAndAmountXmlAsyncWriter amount,
            IMax35TextXmlAsyncWriter information
        )
        {
            this.type = type;
            this.date = date;
            this.country = country;
            this.code = code;
            this.amount = amount;
            this.information = information;
        }
        public async Task WriteAsync(XmlWriter writer, StructuredRegulatoryReporting3 value, string isoNamespace)
        {
            // Type Optional Max35Text System.String
            if ( value.Type is System.String populatedType)
            {
                await writer.WriteStartElementAsync(null, "Tp", isoNamespace );
                await type.WriteAsync(writer, populatedType, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Date Optional ISODate System.DateOnly
            if ( value.Date is System.DateOnly populatedDate)
            {
                await writer.WriteStartElementAsync(null, "Dt", isoNamespace );
                await date.WriteAsync(writer, populatedDate, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Country Optional CountryCode string
            if ( value.Country is string populatedCountry)
            {
                await writer.WriteStartElementAsync(null, "Ctry", isoNamespace );
                await country.WriteAsync(writer, populatedCountry, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Code Optional Max10Text System.String
            if ( value.Code is System.String populatedCode)
            {
                await writer.WriteStartElementAsync(null, "Cd", isoNamespace );
                await code.WriteAsync(writer, populatedCode, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Amount Optional ActiveOrHistoricCurrencyAndAmount System.Decimal
            if ( value.Amount is System.Decimal populatedAmount)
            {
                await writer.WriteStartElementAsync(null, "Amt", isoNamespace );
                await amount.WriteAsync(writer, populatedAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Information Optional Max35Text System.String
            if ( value.Information is System.String populatedInformation)
            {
                await writer.WriteStartElementAsync(null, "Inf", isoNamespace );
                await information.WriteAsync(writer, populatedInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}