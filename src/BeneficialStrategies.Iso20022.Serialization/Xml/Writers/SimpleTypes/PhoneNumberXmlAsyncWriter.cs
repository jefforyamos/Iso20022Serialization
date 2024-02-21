﻿//
// This is a generated template. Edit is allowed.  Please remove this line when first edit is made.
//
// Generated by SimpleTypeSerializationClassGenerator for PhoneNumber.  ISO2002 ID# _YXvFB9p-Ed-ak6NoX_4Aeg_-1045927120.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// The collection of information which identifies a specific phone or FAX number as defined by telecom services.|It consists of a &quot;+&quot; followed by the country code (from 1 to 3 characters) then a &quot;-&quot; and finally, any combination of numbers, &quot;(&quot;, &quot;)&quot;, &quot;+&quot; and &quot;-&quot; (up to 30 characters).
    /// </summary>
    public class PhoneNumberXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.String>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;PhoneNumber&apos; should be formatted.
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