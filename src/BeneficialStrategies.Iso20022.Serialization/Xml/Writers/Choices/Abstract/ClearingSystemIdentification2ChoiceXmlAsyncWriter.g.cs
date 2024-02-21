﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceSerializationGenerator for ClearingSystemIdentification2Choice.  ISO2002 ID# _TMoSENp-Ed-ak6NoX_4Aeg_-1410917193.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification2Choice;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.ClearingSystemIdentification2Choice;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Choices
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="ClearingSystemIdentification2Choice_"/>.
    /// </summary>
    public class ClearingSystemIdentification2ChoiceXmlAsyncWriter : ISubordinateXmlAsyncWriter<ClearingSystemIdentification2Choice_>
    {
        private readonly ClearingSystemIdentification2ChoiceCodeXmlAsyncWriter code;
        private readonly ClearingSystemIdentification2ChoiceProprietaryXmlAsyncWriter proprietary;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public ClearingSystemIdentification2ChoiceXmlAsyncWriter
        (
            ClearingSystemIdentification2ChoiceCodeXmlAsyncWriter code,
            ClearingSystemIdentification2ChoiceProprietaryXmlAsyncWriter proprietary
        )
        {
            this.code = code;
            this.proprietary = proprietary;
        }
        public Task WriteAsync(XmlWriter writer, ClearingSystemIdentification2Choice_ valueBeingSerialized, string isoNamespace)
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