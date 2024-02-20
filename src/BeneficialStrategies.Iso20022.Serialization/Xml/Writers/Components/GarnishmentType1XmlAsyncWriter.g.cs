﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for GarnishmentType1.  ISO2002 ID# _LLLooYnnEeOORMXOfBk1Bw.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="GarnishmentType1"/>.
    /// </summary>
    public class GarnishmentType1XmlAsyncWriter : ISubordinateXmlAsyncWriter<GarnishmentType1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<GarnishmentType1Choice_> codeOrProprietary;
        private readonly IMax35TextXmlAsyncWriter issuer;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public GarnishmentType1XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<GarnishmentType1Choice_> codeOrProprietary,
            IMax35TextXmlAsyncWriter issuer
        )
        {
            this.codeOrProprietary = codeOrProprietary;
            this.issuer = issuer;
        }
        public async Task WriteAsync(XmlWriter writer, GarnishmentType1 value, string isoNamespace)
        {
            // CodeOrProprietary Required GarnishmentType1Choice GarnishmentType1Choice_
            await writer.WriteStartElementAsync(null, "CdOrPrtry", isoNamespace );
            await codeOrProprietary.WriteAsync(writer, value.CodeOrProprietary, isoNamespace);
            await writer.WriteEndElementAsync();
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