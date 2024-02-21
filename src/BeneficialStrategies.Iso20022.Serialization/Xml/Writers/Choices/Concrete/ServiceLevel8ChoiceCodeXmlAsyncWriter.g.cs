﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Code.  ISO2002 ID# _QJa_zdp-Ed-ak6NoX_4Aeg_1912716972.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.ServiceLevel8Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.ServiceLevel8Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Code"/>.
    /// </summary>
    public class ServiceLevel8ChoiceCodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<Code>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IEnumXmlAsyncWriter<ExternalServiceLevel1Code> value;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public ServiceLevel8ChoiceCodeXmlAsyncWriter
        (
            IEnumXmlAsyncWriter<ExternalServiceLevel1Code> value
        )
        {
            this.value = value;
        }
        public async Task WriteAsync(XmlWriter writer, Code valueBeingSerialized, string isoNamespace)
        {
            // Value Required ExternalServiceLevel1Code ExternalServiceLevel1Code
            await writer.WriteStartElementAsync(null, "Cd", isoNamespace );
            await value.WriteAsync(writer, valueBeingSerialized.Value, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}