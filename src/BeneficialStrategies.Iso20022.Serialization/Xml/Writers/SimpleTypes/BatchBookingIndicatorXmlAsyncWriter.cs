﻿//
// This is a generated template. Edit is allowed.  Please remove this line when first edit is made.
//
// Generated by SimpleTypeSerializationClassGenerator for BatchBookingIndicator.  ISO2002 ID# _YXvFBtp-Ed-ak6NoX_4Aeg_205529668.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Identifies whether the sending party requests a single debit or credit entry per individual transaction or a batch entry for the sum of the amounts of all transactions.
    /// </summary>
    public class BatchBookingIndicatorXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.String>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;BatchBookingIndicator&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, System.String value, string isoNamespace)
        {
            // If changes are made to the serialized output, be sure and create a debug log entry.
            writer.WriteValue( value );
            return Task.CompletedTask;
        }
    }
}
