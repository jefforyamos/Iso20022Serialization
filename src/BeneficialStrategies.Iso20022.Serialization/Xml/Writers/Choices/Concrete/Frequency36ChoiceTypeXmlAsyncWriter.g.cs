﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Type.  ISO2002 ID# _seR6MWk2Eeanu6HLe77Rkg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.Frequency36Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.Frequency36Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Type"/>.
    /// </summary>
    public class Frequency36ChoiceTypeXmlAsyncWriter : ISubordinateXmlAsyncWriter<Type>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IEnumXmlAsyncWriter<Frequency6Code> value;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public Frequency36ChoiceTypeXmlAsyncWriter
        (
            IEnumXmlAsyncWriter<Frequency6Code> value
        )
        {
            this.value = value;
        }
        public async Task WriteAsync(XmlWriter writer, Type valueBeingSerialized, string isoNamespace)
        {
            // Value Required Frequency6Code Frequency6Code
            await writer.WriteStartElementAsync(null, "Tp", isoNamespace );
            await value.WriteAsync(writer, valueBeingSerialized.Value, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
