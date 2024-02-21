﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for InstructionForCreditorAgent3.  ISO2002 ID# _PRQQx8QAEemsic1bQcEtLA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Components
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="InstructionForCreditorAgent3"/>.
    /// </summary>
    public class InstructionForCreditorAgent3XmlAsyncWriter : ISubordinateXmlAsyncWriter<InstructionForCreditorAgent3>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IEnumXmlAsyncWriter<ExternalCreditorAgentInstruction1Code> code;
        private readonly IMax140TextXmlAsyncWriter instructionInformation;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public InstructionForCreditorAgent3XmlAsyncWriter
        (
            IEnumXmlAsyncWriter<ExternalCreditorAgentInstruction1Code> code,
            IMax140TextXmlAsyncWriter instructionInformation
        )
        {
            this.code = code;
            this.instructionInformation = instructionInformation;
        }
        public async Task WriteAsync(XmlWriter writer, InstructionForCreditorAgent3 valueBeingSerialized, string isoNamespace)
        {
            // Code Optional ExternalCreditorAgentInstruction1Code ExternalCreditorAgentInstruction1Code
            if ( valueBeingSerialized.Code is ExternalCreditorAgentInstruction1Code populatedCode)
            {
                await writer.WriteStartElementAsync(null, "Cd", isoNamespace );
                await code.WriteAsync(writer, populatedCode, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // InstructionInformation Optional Max140Text System.String
            if ( valueBeingSerialized.InstructionInformation is System.String populatedInstructionInformation)
            {
                await writer.WriteStartElementAsync(null, "InstrInf", isoNamespace );
                await instructionInformation.WriteAsync(writer, populatedInstructionInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
