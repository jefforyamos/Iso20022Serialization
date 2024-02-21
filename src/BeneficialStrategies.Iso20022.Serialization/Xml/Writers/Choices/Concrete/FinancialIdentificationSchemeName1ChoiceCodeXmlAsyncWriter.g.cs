﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Code.  ISO2002 ID# _QALkMdp-Ed-ak6NoX_4Aeg_-2021925430.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.FinancialIdentificationSchemeName1Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.FinancialIdentificationSchemeName1Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Code"/>.
    /// </summary>
    public class FinancialIdentificationSchemeName1ChoiceCodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<Code>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ExternalFinancialInstitutionIdentification1CodeXmlAsyncWriter value;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public FinancialIdentificationSchemeName1ChoiceCodeXmlAsyncWriter
        (
            ExternalFinancialInstitutionIdentification1CodeXmlAsyncWriter value
        )
        {
            this.value = value;
        }
        public async Task WriteAsync(XmlWriter writer, Code valueBeingSerialized, string isoNamespace)
        {
            // Value Required ExternalFinancialInstitutionIdentification1Code string
            await writer.WriteStartElementAsync(null, "Cd", isoNamespace );
            await value.WriteAsync(writer, valueBeingSerialized.Value, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
