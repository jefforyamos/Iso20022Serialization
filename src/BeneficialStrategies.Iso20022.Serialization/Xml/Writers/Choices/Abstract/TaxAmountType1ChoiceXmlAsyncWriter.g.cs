﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceSerializationGenerator for TaxAmountType1Choice.  ISO2002 ID# _tsra0lkyEeGeoaLUQk__nA_-1905418813.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.TaxAmountType1Choice;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Choices
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="TaxAmountType1Choice_"/>.
    /// </summary>
    public class TaxAmountType1ChoiceXmlAsyncWriter : ISubordinateXmlAsyncWriter<TaxAmountType1Choice_>
    {
        private readonly TaxAmountType1ChoiceCodeXmlAsyncWriter code;
        private readonly TaxAmountType1ChoiceProprietaryXmlAsyncWriter proprietary;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public TaxAmountType1ChoiceXmlAsyncWriter
        (
            TaxAmountType1ChoiceCodeXmlAsyncWriter code,
            TaxAmountType1ChoiceProprietaryXmlAsyncWriter proprietary
        )
        {
            this.code = code;
            this.proprietary = proprietary;
        }
        public Task WriteAsync(XmlWriter writer, TaxAmountType1Choice_ valueBeingSerialized, string isoNamespace)
        {
            return valueBeingSerialized switch
            {
                BeneficialStrategies.Iso20022.Choices.TaxAmountType1Choice.Code _code => this.code.WriteAsync( writer, _code, isoNamespace ),
                BeneficialStrategies.Iso20022.Choices.TaxAmountType1Choice.Proprietary _proprietary => this.proprietary.WriteAsync( writer, _proprietary, isoNamespace ),
                _ => throw new InvalidCastException( $"Data type of {valueBeingSerialized.GetType().FullName} has no corresponding serializer.")
            };
        }
    }
}
