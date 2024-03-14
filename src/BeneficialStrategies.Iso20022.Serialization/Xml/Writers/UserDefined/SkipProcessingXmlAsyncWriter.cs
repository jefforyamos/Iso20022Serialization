﻿//
// This is a generated template. Edit is allowed.  Please remove this line when first edit is made.
//
// Generated by UserDefinedSerializationClassGenerator for SkipProcessing.  ISO2002 ID# _RreBWNp-Ed-ak6NoX_4Aeg_-72452402.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.UserDefined
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// The Any element without further validation processing.
    /// </summary>
    public class SkipProcessingXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<SkipProcessing>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;SkipProcessing&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, SkipProcessing value, string isoNamespace)
        {
            // Underlying library does not supply a property to write, implement later.
            // writer.WriteValue( value );
            return Task.CompletedTask;
        }
    }
}
