﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for TaxPeriod3.  ISO2002 ID# _oB4Gpd4lEeqt1ZcLzWyWFw.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="TaxPeriod3"/>.
    /// </summary>
    public class TaxPeriod3XmlAsyncWriter : ISubordinateXmlAsyncWriter<TaxPeriod3>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISOYearXmlAsyncWriter year;
        private readonly TaxRecordPeriod1CodeXmlAsyncWriter type;
        private readonly ISubordinateXmlAsyncWriter<DatePeriod2> fromToDate;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public TaxPeriod3XmlAsyncWriter
        (
            ISOYearXmlAsyncWriter year,
            TaxRecordPeriod1CodeXmlAsyncWriter type,
            ISubordinateXmlAsyncWriter<DatePeriod2> fromToDate
        )
        {
            this.year = year;
            this.type = type;
            this.fromToDate = fromToDate;
        }
        public async Task WriteAsync(XmlWriter writer, TaxPeriod3 valueBeingSerialized, string isoNamespace)
        {
            // Year Optional ISOYear System.UInt16
            if ( valueBeingSerialized.Year is System.UInt16 populatedYear)
            {
                await writer.WriteStartElementAsync(null, "Yr", isoNamespace );
                await year.WriteAsync(writer, populatedYear, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Type Optional TaxRecordPeriod1Code TaxRecordPeriod1Code
            if ( valueBeingSerialized.Type is TaxRecordPeriod1Code populatedType)
            {
                await writer.WriteStartElementAsync(null, "Tp", isoNamespace );
                await type.WriteAsync(writer, populatedType, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // FromToDate Optional DatePeriod2 DatePeriod2
            if ( valueBeingSerialized.FromToDate is DatePeriod2 populatedFromToDate)
            {
                await writer.WriteStartElementAsync(null, "FrToDt", isoNamespace );
                await fromToDate.WriteAsync(writer, populatedFromToDate, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
