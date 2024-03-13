﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceSerializationGenerator for FinancialIdentificationSchemeName1Choice.  ISO2002 ID# _QALkMNp-Ed-ak6NoX_4Aeg_-2021925461.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.FinancialIdentificationSchemeName1Choice;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Choices
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="FinancialIdentificationSchemeName1Choice_"/>.
    /// </summary>
    public class FinancialIdentificationSchemeName1ChoiceXmlAsyncWriter : ISubordinateXmlAsyncWriter<FinancialIdentificationSchemeName1Choice_>
    {
        private readonly FinancialIdentificationSchemeName1ChoiceCodeXmlAsyncWriter code;
        private readonly FinancialIdentificationSchemeName1ChoiceProprietaryXmlAsyncWriter proprietary;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public FinancialIdentificationSchemeName1ChoiceXmlAsyncWriter
        (
            FinancialIdentificationSchemeName1ChoiceCodeXmlAsyncWriter code,
            FinancialIdentificationSchemeName1ChoiceProprietaryXmlAsyncWriter proprietary
        )
        {
            this.code = code;
            this.proprietary = proprietary;
        }
        public Task WriteAsync(XmlWriter writer, FinancialIdentificationSchemeName1Choice_ valueBeingSerialized, string isoNamespace)
        {
            return valueBeingSerialized switch
            {
                BeneficialStrategies.Iso20022.Choices.FinancialIdentificationSchemeName1Choice.Code _code => this.code.WriteAsync( writer, _code, isoNamespace ),
                BeneficialStrategies.Iso20022.Choices.FinancialIdentificationSchemeName1Choice.Proprietary _proprietary => this.proprietary.WriteAsync( writer, _proprietary, isoNamespace ),
                _ => throw new InvalidCastException( $"Data type of {valueBeingSerialized.GetType().FullName} has no corresponding serializer.")
            };
        }
    }
}
