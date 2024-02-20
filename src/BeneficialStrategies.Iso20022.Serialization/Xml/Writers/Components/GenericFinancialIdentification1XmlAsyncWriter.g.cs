﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for GenericFinancialIdentification1.  ISO2002 ID# _QALkM9p-Ed-ak6NoX_4Aeg_-2141717394.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="GenericFinancialIdentification1"/>.
    /// </summary>
    public class GenericFinancialIdentification1XmlAsyncWriter : ISubordinateXmlAsyncWriter<GenericFinancialIdentification1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IMax35TextXmlAsyncWriter identification;
        private readonly ISubordinateXmlAsyncWriter<FinancialIdentificationSchemeName1Choice_> schemeName;
        private readonly IMax35TextXmlAsyncWriter issuer;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public GenericFinancialIdentification1XmlAsyncWriter
        (
            IMax35TextXmlAsyncWriter identification,
            ISubordinateXmlAsyncWriter<FinancialIdentificationSchemeName1Choice_> schemeName,
            IMax35TextXmlAsyncWriter issuer
        )
        {
            this.identification = identification;
            this.schemeName = schemeName;
            this.issuer = issuer;
        }
        public async Task WriteAsync(XmlWriter writer, GenericFinancialIdentification1 value, string isoNamespace)
        {
            // Identification Required Max35Text System.String
            await writer.WriteStartElementAsync(null, "Id", isoNamespace );
            await identification.WriteAsync(writer, value.Identification, isoNamespace);
            await writer.WriteEndElementAsync();
            // SchemeName Optional FinancialIdentificationSchemeName1Choice FinancialIdentificationSchemeName1Choice_
            if ( value.SchemeName is FinancialIdentificationSchemeName1Choice_ populatedSchemeName)
            {
                await writer.WriteStartElementAsync(null, "SchmeNm", isoNamespace );
                await schemeName.WriteAsync(writer, populatedSchemeName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Issuer Optional Max35Text System.String
            if ( value.Issuer is System.String populatedIssuer)
            {
                await writer.WriteStartElementAsync(null, "Issr", isoNamespace );
                await issuer.WriteAsync(writer, populatedIssuer, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}