﻿//
// This is a generated template. Edit is allowed.  Please remove this line when first edit is made.
//
// Generated by ExternalSchemaSerializationClassGenerator for LaxPayload.  ISO2002 ID# _OTgzNDAz-AOSNFX-8224503.
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
    /// Specifies a data structure that allows to include any valid XML Structure (e.g. through an XML Schema). The property namespace is set to &apos;any&apos;.
    /// The processContents value is &apos;lax&apos; which according to the above specification and to Iso20022:2013 means: If the item has a uniquely determined declaration available, it must be ·valid· with respect to that definition, that is, ·validate· if you can, don&apos;t worry if you can&apos;t, i.e. it MAY be validated or not.
    /// </summary>
    public class LaxPayloadXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<LaxPayload>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;LaxPayload&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, LaxPayload value, string isoNamespace)
        {
            // Underlying library does not supply a property to write, implement later.
            // writer.WriteValue( value );
            return Task.CompletedTask;
        }
    }
}
