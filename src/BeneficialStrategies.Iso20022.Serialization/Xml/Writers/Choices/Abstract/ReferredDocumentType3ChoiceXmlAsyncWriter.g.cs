﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceSerializationGenerator for ReferredDocumentType3Choice.  ISO2002 ID# _XxL1Jx77EeSxevWRRWxNAg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.ReferredDocumentType3Choice;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.ReferredDocumentType3Choice;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Choices
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="ReferredDocumentType3Choice_"/>.
    /// </summary>
    public class ReferredDocumentType3ChoiceXmlAsyncWriter : ISubordinateXmlAsyncWriter<ReferredDocumentType3Choice_>
    {
        private readonly ReferredDocumentType3ChoiceCodeXmlAsyncWriter code;
        private readonly ReferredDocumentType3ChoiceProprietaryXmlAsyncWriter proprietary;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public ReferredDocumentType3ChoiceXmlAsyncWriter
        (
            ReferredDocumentType3ChoiceCodeXmlAsyncWriter code,
            ReferredDocumentType3ChoiceProprietaryXmlAsyncWriter proprietary
        )
        {
            this.code = code;
            this.proprietary = proprietary;
        }
        public Task WriteAsync(XmlWriter writer, ReferredDocumentType3Choice_ valueBeingSerialized, string isoNamespace)
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