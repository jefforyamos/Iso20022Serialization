﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for CreditorReferenceType2.  ISO2002 ID# _T4ItMtp-Ed-ak6NoX_4Aeg_604337645.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="CreditorReferenceType2"/>.
    /// </summary>
    public class CreditorReferenceType2XmlAsyncWriter : ISubordinateXmlAsyncWriter<CreditorReferenceType2>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<CreditorReferenceType1Choice_> codeOrProprietary;
        private readonly Max35TextXmlAsyncWriter issuer;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public CreditorReferenceType2XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<CreditorReferenceType1Choice_> codeOrProprietary,
            Max35TextXmlAsyncWriter issuer
        )
        {
            this.codeOrProprietary = codeOrProprietary;
            this.issuer = issuer;
        }
        public async Task WriteAsync(XmlWriter writer, CreditorReferenceType2 valueBeingSerialized, string isoNamespace)
        {
            // CodeOrProprietary Required CreditorReferenceType1Choice CreditorReferenceType1Choice_
            await writer.WriteStartElementAsync(null, "CdOrPrtry", isoNamespace );
            await codeOrProprietary.WriteAsync(writer, valueBeingSerialized.CodeOrProprietary, isoNamespace);
            await writer.WriteEndElementAsync();
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
