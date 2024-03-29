﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Period.  ISO2002 ID# _seR6M2k2Eeanu6HLe77Rkg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.Frequency36Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

using Period = BeneficialStrategies.Iso20022.Choices.Frequency36Choice.Period;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.Frequency36Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Period"/>.
    /// </summary>
    public class Frequency36ChoicePeriodXmlAsyncWriter : ISubordinateXmlAsyncWriter<Period>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Frequency6CodeXmlAsyncWriter type;
        private readonly DecimalNumberXmlAsyncWriter countPerPeriod;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public Frequency36ChoicePeriodXmlAsyncWriter
        (
            Frequency6CodeXmlAsyncWriter type,
            DecimalNumberXmlAsyncWriter countPerPeriod
        )
        {
            this.type = type;
            this.countPerPeriod = countPerPeriod;
        }
        public async Task WriteAsync(XmlWriter writer, Period valueBeingSerialized, string isoNamespace)
        {
            await writer.WriteStartElementAsync(null, "Prd", isoNamespace); // ConcreteChoiceIndicator
            // Type Required Frequency6Code Frequency6Code
            await writer.WriteStartElementAsync(null, "Tp", isoNamespace );
            await type.WriteAsync(writer, valueBeingSerialized.Type, isoNamespace);
            await writer.WriteEndElementAsync();
            // CountPerPeriod Required DecimalNumber System.UInt64
            await writer.WriteStartElementAsync(null, "CntPerPrd", isoNamespace );
            await countPerPeriod.WriteAsync(writer, valueBeingSerialized.CountPerPeriod, isoNamespace);
            await writer.WriteEndElementAsync();
            await writer.WriteEndElementAsync(); // Concrete choice indicator
        }
    }
}
