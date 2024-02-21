﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Proprietary.  ISO2002 ID# _QJa_ztp-Ed-ak6NoX_4Aeg_1912716994.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.ServiceLevel8Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.ServiceLevel8Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Proprietary"/>.
    /// </summary>
    public class ServiceLevel8ChoiceProprietaryXmlAsyncWriter : ISubordinateXmlAsyncWriter<Proprietary>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max35TextXmlAsyncWriter value;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public ServiceLevel8ChoiceProprietaryXmlAsyncWriter
        (
            Max35TextXmlAsyncWriter value
        )
        {
            this.value = value;
        }
        public async Task WriteAsync(XmlWriter writer, Proprietary valueBeingSerialized, string isoNamespace)
        {
            // Value Required Max35Text System.String
            await writer.WriteStartElementAsync(null, "Prtry", isoNamespace );
            await value.WriteAsync(writer, valueBeingSerialized.Value, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
