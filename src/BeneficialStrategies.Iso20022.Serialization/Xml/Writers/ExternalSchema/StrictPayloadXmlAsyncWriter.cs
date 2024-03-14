﻿//
// This is a generated template. Edit is allowed.  Please remove this line when first edit is made.
//
// Generated by ExternalSchemaSerializationClassGenerator for StrictPayload.  ISO2002 ID# _OTE5NjQ4-AOSNFX-8441933.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.ExternalSchema;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.ExternalSchema
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.  Format information: 
    /// Specifies a data structure that allows the inclusion of any valid XML structure, for example, through an XML Schema. The property namespace is set to &apos;any&apos;.
    /// The processContents value is &apos;strict&apos; which according to the above specification and to ISO 20022: 2013 means that the application must understand and validate the content.
    /// </summary>
    public class StrictPayloadXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<StrictPayload>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;StrictPayload&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, StrictPayload value, string isoNamespace)
        {
            // Underlying library does not supply a property to write, implement later.
            // writer.WriteValue( value );
            return Task.CompletedTask;
        }
    }
}
