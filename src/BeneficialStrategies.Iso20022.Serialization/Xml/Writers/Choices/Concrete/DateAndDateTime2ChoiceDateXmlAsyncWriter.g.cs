﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Date.  ISO2002 ID# _fPH6gZlhEeeE1Ya-LgRsuQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.DateAndDateTime2Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Date"/>.
    /// </summary>
    public class DateAndDateTime2ChoiceDateXmlAsyncWriter : ISubordinateXmlAsyncWriter<Date>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISODateXmlAsyncWriter value;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public DateAndDateTime2ChoiceDateXmlAsyncWriter
        (
            ISODateXmlAsyncWriter value
        )
        {
            this.value = value;
        }
        public async Task WriteAsync(XmlWriter writer, Date valueBeingSerialized, string isoNamespace)
        {
            // Value Required ISODate System.DateOnly
            await writer.WriteStartElementAsync(null, "Dt", isoNamespace );
            await value.WriteAsync(writer, valueBeingSerialized.Value, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}
