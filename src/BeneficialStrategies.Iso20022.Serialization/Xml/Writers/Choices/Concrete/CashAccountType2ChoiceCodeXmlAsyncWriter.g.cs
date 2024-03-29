﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Code.  ISO2002 ID# _sb6WgVkyEeGeoaLUQk__nA_-1937269286.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.CashAccountType2Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

using Code = BeneficialStrategies.Iso20022.Choices.CashAccountType2Choice.Code;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.CashAccountType2Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Code"/>.
    /// </summary>
    public class CashAccountType2ChoiceCodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<Code>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ExternalCashAccountType1CodeXmlAsyncWriter value;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public CashAccountType2ChoiceCodeXmlAsyncWriter
        (
            ExternalCashAccountType1CodeXmlAsyncWriter value
        )
        {
            this.value = value;
        }
        public async Task WriteAsync(XmlWriter writer, Code valueBeingSerialized, string isoNamespace)
        {
            await writer.WriteStartElementAsync(null, "Cd", isoNamespace); // ConcreteChoiceIndicator
            // Value Required ExternalCashAccountType1Code ExternalCashAccountType1Code
            await value.WriteAsync(writer, valueBeingSerialized.Value, isoNamespace);
            await writer.WriteEndElementAsync(); // Concrete choice indicator
        }
    }
}
