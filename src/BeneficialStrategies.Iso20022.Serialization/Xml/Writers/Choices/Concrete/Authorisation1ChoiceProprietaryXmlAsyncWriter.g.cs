﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Proprietary.  ISO2002 ID# _RD_KkNp-Ed-ak6NoX_4Aeg_-955120080.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.Authorisation1Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

using Proprietary = BeneficialStrategies.Iso20022.Choices.Authorisation1Choice.Proprietary;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.Authorisation1Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Proprietary"/>.
    /// </summary>
    public class Authorisation1ChoiceProprietaryXmlAsyncWriter : ISubordinateXmlAsyncWriter<Proprietary>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max128TextXmlAsyncWriter value;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public Authorisation1ChoiceProprietaryXmlAsyncWriter
        (
            Max128TextXmlAsyncWriter value
        )
        {
            this.value = value;
        }
        public async Task WriteAsync(XmlWriter writer, Proprietary valueBeingSerialized, string isoNamespace)
        {
            await writer.WriteStartElementAsync(null, "Prtry", isoNamespace); // ConcreteChoiceIndicator
            // Value Required Max128Text System.String
            await value.WriteAsync(writer, valueBeingSerialized.Value, isoNamespace);
            await writer.WriteEndElementAsync(); // Concrete choice indicator
        }
    }
}
