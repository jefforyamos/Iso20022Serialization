﻿//
// Generated by SimpleTypeSerializationClassGenerator for Max5Number.  ISO2002 ID# _axZ9oHNCEeWkbcw9bLh6lw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Number (max 99999) of objects represented as an integer.
    /// </summary>
    public class Max5NumberXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.UInt64>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;Max5Number&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, System.UInt64 value, string isoNamespace)
        {
            // If changes are made to the serialized output, be sure and create a debug log entry.
            writer.WriteValue( value.ToString() );
            return Task.CompletedTask;
        }
    }
}
