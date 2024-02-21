﻿//
// This is a generated template. Edit is allowed.  Please remove this line when first edit is made.
//
// Generated by SimpleTypeSerializationClassGenerator for LongFraction21DecimalNumber.  ISO2002 ID# _Q3YnQf9CEearO5FpX4NQag.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
    /// </summary>
    public class LongFraction21DecimalNumberXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.UInt64>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;LongFraction21DecimalNumber&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, System.UInt64 value, string isoNamespace)
        {
            // If changes are made to the serialized output, be sure and create a debug log entry.
            writer.WriteValue( value );
            return Task.CompletedTask;
        }
    }
}
