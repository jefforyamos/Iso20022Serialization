﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for RegulatoryAuthority2.  ISO2002 ID# _Pc3bxNp-Ed-ak6NoX_4Aeg_-1526379440.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="RegulatoryAuthority2"/>.
    /// </summary>
    public class RegulatoryAuthority2XmlAsyncWriter : ISubordinateXmlAsyncWriter<RegulatoryAuthority2>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IMax140TextXmlAsyncWriter name;
        private readonly ICountryCodeXmlAsyncWriter country;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public RegulatoryAuthority2XmlAsyncWriter
        (
            IMax140TextXmlAsyncWriter name,
            ICountryCodeXmlAsyncWriter country
        )
        {
            this.name = name;
            this.country = country;
        }
        public async Task WriteAsync(XmlWriter writer, RegulatoryAuthority2 value, string isoNamespace)
        {
            // Name Optional Max140Text System.String
            if ( value.Name is System.String populatedName)
            {
                await writer.WriteStartElementAsync(null, "Nm", isoNamespace );
                await name.WriteAsync(writer, populatedName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Country Optional CountryCode string
            if ( value.Country is string populatedCountry)
            {
                await writer.WriteStartElementAsync(null, "Ctry", isoNamespace );
                await country.WriteAsync(writer, populatedCountry, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
