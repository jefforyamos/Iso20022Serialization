﻿//
// Generated by SimpleTypeSerializationClassGenerator for ISODate.  ISO2002 ID# _YXSZFtp-Ed-ak6NoX_4Aeg_2032498111.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in &quot;XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004&quot; which is aligned with ISO 8601.
    /// </summary>
    public class ISODateXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.DateOnly>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;ISODate&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, System.DateOnly value, string isoNamespace)
        {
            writer.WriteValue( value.ToString("yyyy-MM-dd") );
            return Task.CompletedTask;
        }
    }
}
