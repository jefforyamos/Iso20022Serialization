﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for DateAndPlaceOfBirth1.  ISO2002 ID# _jU8IEa9UEeeJJK1oRb-jTw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="DateAndPlaceOfBirth1"/>.
    /// </summary>
    public class DateAndPlaceOfBirth1XmlAsyncWriter : ISubordinateXmlAsyncWriter<DateAndPlaceOfBirth1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISODateXmlAsyncWriter birthDate;
        private readonly Max35TextXmlAsyncWriter provinceOfBirth;
        private readonly Max35TextXmlAsyncWriter cityOfBirth;
        private readonly CountryCodeXmlAsyncWriter countryOfBirth;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public DateAndPlaceOfBirth1XmlAsyncWriter
        (
            ISODateXmlAsyncWriter birthDate,
            Max35TextXmlAsyncWriter provinceOfBirth,
            Max35TextXmlAsyncWriter cityOfBirth,
            CountryCodeXmlAsyncWriter countryOfBirth
        )
        {
            this.birthDate = birthDate;
            this.provinceOfBirth = provinceOfBirth;
            this.cityOfBirth = cityOfBirth;
            this.countryOfBirth = countryOfBirth;
        }
        public async Task WriteAsync(XmlWriter writer, DateAndPlaceOfBirth1 valueBeingSerialized, string isoNamespace)
        {
            // BirthDate Required ISODate System.DateOnly
            await writer.WriteStartElementAsync(null, "BirthDt", isoNamespace );
            await birthDate.WriteAsync(writer, valueBeingSerialized.BirthDate, isoNamespace);
            await writer.WriteEndElementAsync();
            // ProvinceOfBirth Optional Max35Text System.String
            if ( valueBeingSerialized.ProvinceOfBirth is System.String populatedProvinceOfBirth)
            {
                await writer.WriteStartElementAsync(null, "PrvcOfBirth", isoNamespace );
                await provinceOfBirth.WriteAsync(writer, populatedProvinceOfBirth, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CityOfBirth Required Max35Text System.String
            await writer.WriteStartElementAsync(null, "CityOfBirth", isoNamespace );
            await cityOfBirth.WriteAsync(writer, valueBeingSerialized.CityOfBirth, isoNamespace);
            await writer.WriteEndElementAsync();
            // CountryOfBirth Required CountryCode string
            await writer.WriteStartElementAsync(null, "CtryOfBirth", isoNamespace );
            await countryOfBirth.WriteAsync(writer, valueBeingSerialized.CountryOfBirth, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
