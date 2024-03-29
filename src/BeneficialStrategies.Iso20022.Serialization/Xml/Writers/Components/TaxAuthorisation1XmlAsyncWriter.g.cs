﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for TaxAuthorisation1.  ISO2002 ID# _Pc3bx9p-Ed-ak6NoX_4Aeg_-197973580.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="TaxAuthorisation1"/>.
    /// </summary>
    public class TaxAuthorisation1XmlAsyncWriter : ISubordinateXmlAsyncWriter<TaxAuthorisation1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max35TextXmlAsyncWriter title;
        private readonly Max140TextXmlAsyncWriter name;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public TaxAuthorisation1XmlAsyncWriter
        (
            Max35TextXmlAsyncWriter title,
            Max140TextXmlAsyncWriter name
        )
        {
            this.title = title;
            this.name = name;
        }
        public async Task WriteAsync(XmlWriter writer, TaxAuthorisation1 valueBeingSerialized, string isoNamespace)
        {
            // Title Optional Max35Text System.String
            if ( valueBeingSerialized.Title is System.String populatedTitle)
            {
                await writer.WriteStartElementAsync(null, "Titl", isoNamespace );
                await title.WriteAsync(writer, populatedTitle, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Name Optional Max140Text System.String
            if ( valueBeingSerialized.Name is System.String populatedName)
            {
                await writer.WriteStartElementAsync(null, "Nm", isoNamespace );
                await name.WriteAsync(writer, populatedName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
