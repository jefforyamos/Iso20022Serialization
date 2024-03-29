﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceSerializationGenerator for AddressType3Choice.  ISO2002 ID# _CneugRb-EeiyVv5j1vf1VQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.AddressType3Choice;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Choices
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="AddressType3Choice_"/>.
    /// </summary>
    public class AddressType3ChoiceXmlAsyncWriter : ISubordinateXmlAsyncWriter<AddressType3Choice_>
    {
        private readonly AddressType3ChoiceCodeXmlAsyncWriter code;
        private readonly AddressType3ChoiceProprietaryXmlAsyncWriter proprietary;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public AddressType3ChoiceXmlAsyncWriter
        (
            AddressType3ChoiceCodeXmlAsyncWriter code,
            AddressType3ChoiceProprietaryXmlAsyncWriter proprietary
        )
        {
            this.code = code;
            this.proprietary = proprietary;
        }
        public Task WriteAsync(XmlWriter writer, AddressType3Choice_ valueBeingSerialized, string isoNamespace)
        {
            return valueBeingSerialized switch
            {
                BeneficialStrategies.Iso20022.Choices.AddressType3Choice.Code _code => this.code.WriteAsync( writer, _code, isoNamespace ),
                BeneficialStrategies.Iso20022.Choices.AddressType3Choice.Proprietary _proprietary => this.proprietary.WriteAsync( writer, _proprietary, isoNamespace ),
                _ => throw new InvalidCastException( $"Data type of {valueBeingSerialized.GetType().FullName} has no corresponding serializer.")
            };
        }
    }
}
