﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Code.  ISO2002 ID# _u3TXxNomEembTrt_WixjyQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AdviceType1Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.AdviceType1Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Code"/>.
    /// </summary>
    public class AdviceType1ChoiceCodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<Code>
    {
        // Injected dependencies for serialization of each member data type
        private readonly AdviceType1CodeXmlAsyncWriter value;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public AdviceType1ChoiceCodeXmlAsyncWriter
        (
            AdviceType1CodeXmlAsyncWriter value
        )
        {
            this.value = value;
        }
        public async Task WriteAsync(XmlWriter writer, Code valueBeingSerialized, string isoNamespace)
        {
            // Value Required AdviceType1Code AdviceType1Code
            await writer.WriteStartElementAsync(null, "Cd", isoNamespace );
            await value.WriteAsync(writer, valueBeingSerialized.Value, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
