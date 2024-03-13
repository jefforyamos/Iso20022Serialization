﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceSerializationGenerator for Authorisation1Choice.  ISO2002 ID# _RD1Zltp-Ed-ak6NoX_4Aeg_-955120203.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.Authorisation1Choice;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Choices
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Authorisation1Choice_"/>.
    /// </summary>
    public class Authorisation1ChoiceXmlAsyncWriter : ISubordinateXmlAsyncWriter<Authorisation1Choice_>
    {
        private readonly Authorisation1ChoiceCodeXmlAsyncWriter code;
        private readonly Authorisation1ChoiceProprietaryXmlAsyncWriter proprietary;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public Authorisation1ChoiceXmlAsyncWriter
        (
            Authorisation1ChoiceCodeXmlAsyncWriter code,
            Authorisation1ChoiceProprietaryXmlAsyncWriter proprietary
        )
        {
            this.code = code;
            this.proprietary = proprietary;
        }
        public Task WriteAsync(XmlWriter writer, Authorisation1Choice_ valueBeingSerialized, string isoNamespace)
        {
            return valueBeingSerialized switch
            {
                BeneficialStrategies.Iso20022.Choices.Authorisation1Choice.Code _code => this.code.WriteAsync( writer, _code, isoNamespace ),
                BeneficialStrategies.Iso20022.Choices.Authorisation1Choice.Proprietary _proprietary => this.proprietary.WriteAsync( writer, _proprietary, isoNamespace ),
                _ => throw new InvalidCastException( $"Data type of {valueBeingSerialized.GetType().FullName} has no corresponding serializer.")
            };
        }
    }
}
