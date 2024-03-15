﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Code.  ISO2002 ID# __rM9WabkEeKvUvwX_r3tzA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.DocumentLineType1Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

using Code = BeneficialStrategies.Iso20022.Choices.DocumentLineType1Choice.Code;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.DocumentLineType1Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Code"/>.
    /// </summary>
    public class DocumentLineType1ChoiceCodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<Code>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ExternalDocumentLineType1CodeXmlAsyncWriter value;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public DocumentLineType1ChoiceCodeXmlAsyncWriter
        (
            ExternalDocumentLineType1CodeXmlAsyncWriter value
        )
        {
            this.value = value;
        }
        public async Task WriteAsync(XmlWriter writer, Code valueBeingSerialized, string isoNamespace)
        {
            await writer.WriteStartElementAsync(null, "Cd", isoNamespace); // ConcreteChoiceIndicator
            // Value Required ExternalDocumentLineType1Code ExternalDocumentLineType1Code
            await writer.WriteStartElementAsync(null, "Cd", isoNamespace );
            await value.WriteAsync(writer, valueBeingSerialized.Value, isoNamespace);
            await writer.WriteEndElementAsync();
            await writer.WriteEndElementAsync(); // Concrete choice indicator
        }
    }
}
