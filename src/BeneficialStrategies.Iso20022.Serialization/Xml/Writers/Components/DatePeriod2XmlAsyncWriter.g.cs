﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for DatePeriod2.  ISO2002 ID# _lZP5MYaDEee8r9VKRbnJSg.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="DatePeriod2"/>.
    /// </summary>
    public class DatePeriod2XmlAsyncWriter : ISubordinateXmlAsyncWriter<DatePeriod2>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IISODateXmlAsyncWriter fromDate;
        private readonly IISODateXmlAsyncWriter toDate;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public DatePeriod2XmlAsyncWriter
        (
            IISODateXmlAsyncWriter fromDate,
            IISODateXmlAsyncWriter toDate
        )
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
        }
        public async Task WriteAsync(XmlWriter writer, DatePeriod2 value, string isoNamespace)
        {
            // FromDate Required ISODate System.DateOnly
            await writer.WriteStartElementAsync(null, "FrDt", isoNamespace );
            await fromDate.WriteAsync(writer, value.FromDate, isoNamespace);
            await writer.WriteEndElementAsync();
            // ToDate Required ISODate System.DateOnly
            await writer.WriteStartElementAsync(null, "ToDt", isoNamespace );
            await toDate.WriteAsync(writer, value.ToDate, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
