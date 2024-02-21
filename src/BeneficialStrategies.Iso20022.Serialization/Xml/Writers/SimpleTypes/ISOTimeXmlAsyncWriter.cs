﻿//
// This is a generated template. Edit is allowed.  Please remove this line when first edit is made.
//
// Generated by SimpleTypeSerializationClassGenerator for ISOTime.  ISO2002 ID# _YYU64dp-Ed-ak6NoX_4Aeg_-1253016814.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// A particular point in the progression of time in a calendar day expressed in either UTC time format (hh:mm:ss.sssZ), local time with UTC offset format (hh:mm:ss.sss+/-hh:mm), or local time format (hh:mm:ss.sss). These representations are defined in &quot;XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004&quot; which is aligned with ISO 8601.|Note on the time format:|1) beginning / end of calendar day|00:00:00 = the beginning of a calendar day|24:00:00 = the end of a calendar day|2) fractions of second in time format|Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.
    /// </summary>
    public class ISOTimeXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.TimeOnly>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;ISOTime&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, System.TimeOnly value, string isoNamespace)
        {
            // If changes are made to the serialized output, be sure and create a debug log entry.
            writer.WriteValue( value );
            return Task.CompletedTask;
        }
    }
}