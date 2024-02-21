﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Code.  ISO2002 ID# _dyoclXh3EeidzqjNEfehPg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.ProxyAccountType1Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.ProxyAccountType1Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Code"/>.
    /// </summary>
    public class ProxyAccountType1ChoiceCodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<Code>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ExternalProxyAccountType1CodeXmlAsyncWriter value;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public ProxyAccountType1ChoiceCodeXmlAsyncWriter
        (
            ExternalProxyAccountType1CodeXmlAsyncWriter value
        )
        {
            this.value = value;
        }
        public async Task WriteAsync(XmlWriter writer, Code valueBeingSerialized, string isoNamespace)
        {
            // Value Required ExternalProxyAccountType1Code ExternalProxyAccountType1Code
            await writer.WriteStartElementAsync(null, "Cd", isoNamespace );
            await value.WriteAsync(writer, valueBeingSerialized.Value, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
