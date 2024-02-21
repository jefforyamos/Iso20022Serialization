﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Party.  ISO2002 ID# _8U6MM248EeiU9cctagi5ow.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.Party40Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.Party40Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Party"/>.
    /// </summary>
    public class Party40ChoicePartyXmlAsyncWriter : ISubordinateXmlAsyncWriter<Party>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IMax140TextXmlAsyncWriter name;
        private readonly ISubordinateXmlAsyncWriter<PostalAddress24> postalAddress;
        private readonly ISubordinateXmlAsyncWriter<Party38Choice_> identification;
        private readonly ICountryCodeXmlAsyncWriter countryOfResidence;
        private readonly ISubordinateXmlAsyncWriter<Contact4> contactDetails;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public Party40ChoicePartyXmlAsyncWriter
        (
            IMax140TextXmlAsyncWriter name,
            ISubordinateXmlAsyncWriter<PostalAddress24> postalAddress,
            ISubordinateXmlAsyncWriter<Party38Choice_> identification,
            ICountryCodeXmlAsyncWriter countryOfResidence,
            ISubordinateXmlAsyncWriter<Contact4> contactDetails
        )
        {
            this.name = name;
            this.postalAddress = postalAddress;
            this.identification = identification;
            this.countryOfResidence = countryOfResidence;
            this.contactDetails = contactDetails;
        }
        public async Task WriteAsync(XmlWriter writer, Party valueBeingSerialized, string isoNamespace)
        {
            // Name Optional Max140Text System.String
            if ( valueBeingSerialized.Name is System.String populatedName)
            {
                await writer.WriteStartElementAsync(null, "Nm", isoNamespace );
                await name.WriteAsync(writer, populatedName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // PostalAddress Optional PostalAddress24 PostalAddress24
            if ( valueBeingSerialized.PostalAddress is PostalAddress24 populatedPostalAddress)
            {
                await writer.WriteStartElementAsync(null, "PstlAdr", isoNamespace );
                await postalAddress.WriteAsync(writer, populatedPostalAddress, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Identification Optional Party38Choice Party38Choice_
            if ( valueBeingSerialized.Identification is Party38Choice_ populatedIdentification)
            {
                await writer.WriteStartElementAsync(null, "Id", isoNamespace );
                await identification.WriteAsync(writer, populatedIdentification, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CountryOfResidence Optional CountryCode string
            if ( valueBeingSerialized.CountryOfResidence is string populatedCountryOfResidence)
            {
                await writer.WriteStartElementAsync(null, "CtryOfRes", isoNamespace );
                await countryOfResidence.WriteAsync(writer, populatedCountryOfResidence, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // ContactDetails Optional Contact4 Contact4
            if ( valueBeingSerialized.ContactDetails is Contact4 populatedContactDetails)
            {
                await writer.WriteStartElementAsync(null, "CtctDtls", isoNamespace );
                await contactDetails.WriteAsync(writer, populatedContactDetails, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
