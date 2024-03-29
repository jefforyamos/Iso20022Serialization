﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for GenericOrganisationIdentification1.  ISO2002 ID# _QACaRdp-Ed-ak6NoX_4Aeg_-322320404.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="GenericOrganisationIdentification1"/>.
    /// </summary>
    public class GenericOrganisationIdentification1XmlAsyncWriter : ISubordinateXmlAsyncWriter<GenericOrganisationIdentification1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max35TextXmlAsyncWriter identification;
        private readonly ISubordinateXmlAsyncWriter<OrganisationIdentificationSchemeName1Choice_> schemeName;
        private readonly Max35TextXmlAsyncWriter issuer;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public GenericOrganisationIdentification1XmlAsyncWriter
        (
            Max35TextXmlAsyncWriter identification,
            ISubordinateXmlAsyncWriter<OrganisationIdentificationSchemeName1Choice_> schemeName,
            Max35TextXmlAsyncWriter issuer
        )
        {
            this.identification = identification;
            this.schemeName = schemeName;
            this.issuer = issuer;
        }
        public async Task WriteAsync(XmlWriter writer, GenericOrganisationIdentification1 valueBeingSerialized, string isoNamespace)
        {
            // Identification Required Max35Text System.String
            await writer.WriteStartElementAsync(null, "Id", isoNamespace );
            await identification.WriteAsync(writer, valueBeingSerialized.Identification, isoNamespace);
            await writer.WriteEndElementAsync();
            // SchemeName Optional OrganisationIdentificationSchemeName1Choice OrganisationIdentificationSchemeName1Choice_
            if ( valueBeingSerialized.SchemeName is OrganisationIdentificationSchemeName1Choice_ populatedSchemeName)
            {
                await writer.WriteStartElementAsync(null, "SchmeNm", isoNamespace );
                await schemeName.WriteAsync(writer, populatedSchemeName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Issuer Optional Max35Text System.String
            if ( valueBeingSerialized.Issuer is System.String populatedIssuer)
            {
                await writer.WriteStartElementAsync(null, "Issr", isoNamespace );
                await issuer.WriteAsync(writer, populatedIssuer, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
