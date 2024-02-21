﻿//
// This is a generated template. Edit is allowed.  Please remove this line when first edit is made.
//
// Generated by SimpleTypeSerializationClassGenerator for Restricted15DigitCurrencyAndAmount.  ISO2002 ID# _hldkIFmsEea0TrLY-ZieOg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Number of monetary units specified in a currency, where the unit of currency is explicit and compliant with ISO 4217. The maximum number of digits must not exceed 15, including a maximum of 5 fractional digits.
    /// </summary>
    public class Restricted15DigitCurrencyAndAmountXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.Decimal>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;Restricted15DigitCurrencyAndAmount&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, System.Decimal value, string isoNamespace)
        {
            // If changes are made to the serialized output, be sure and create a debug log entry.
            writer.WriteValue( value );
            return Task.CompletedTask;
        }
    }
}