﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceSerializationGenerator for GarnishmentType1Choice.  ISO2002 ID# _k8MIkYnnEeOORMXOfBk1Bw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.GarnishmentType1Choice;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.GarnishmentType1Choice;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Choices
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="GarnishmentType1Choice_"/>.
    /// </summary>
    public class GarnishmentType1ChoiceXmlAsyncWriter : ISubordinateXmlAsyncWriter<GarnishmentType1Choice_>
    {
        private readonly GarnishmentType1ChoiceCodeXmlAsyncWriter code;
        private readonly GarnishmentType1ChoiceProprietaryXmlAsyncWriter proprietary;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public GarnishmentType1ChoiceXmlAsyncWriter
        (
            GarnishmentType1ChoiceCodeXmlAsyncWriter code,
            GarnishmentType1ChoiceProprietaryXmlAsyncWriter proprietary
        )
        {
            this.code = code;
            this.proprietary = proprietary;
        }
        public Task WriteAsync(XmlWriter writer, GarnishmentType1Choice_ valueBeingSerialized, string isoNamespace)
        {
            return valueBeingSerialized switch
            {
                Code _code => this.code.WriteAsync( writer, _code, isoNamespace ),
                Proprietary _proprietary => this.proprietary.WriteAsync( writer, _proprietary, isoNamespace ),
                _ => throw new InvalidCastException( $"Data type of {valueBeingSerialized.GetType().FullName} has no corresponding serializer.")
            };
        }
    }
}