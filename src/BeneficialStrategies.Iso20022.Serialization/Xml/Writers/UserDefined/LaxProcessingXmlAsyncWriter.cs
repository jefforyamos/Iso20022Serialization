﻿//
// This is a generated template. Edit is allowed.  Please remove this line when first edit is made.
//
// Generated by UserDefinedSerializationClassGenerator for LaxProcessing.  ISO2002 ID# _jLSza-5NEeCisYr99QEiWA_-1693515579.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.UserDefined
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// 
    /// </summary>
    public class LaxProcessingXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<LaxProcessing>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;LaxProcessing&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, LaxProcessing value, string isoNamespace)
        {
            // Underlying library does not supply a property to write, implement later.
            // writer.WriteValue( value );
            return Task.CompletedTask;
        }
    }
}
