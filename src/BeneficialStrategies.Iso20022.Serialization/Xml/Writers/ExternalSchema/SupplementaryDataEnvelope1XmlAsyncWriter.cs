﻿//
// This is a generated template. Edit is allowed.  Please remove this line when first edit is made.
//
// Generated by ExternalSchemaSerializationClassGenerator for SupplementaryDataEnvelope1.  ISO2002 ID# _Kz9KwJDrEeSLQ8ob-qtemg.
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
    /// Technical component that contains the validated supplementary data information. This technical envelope allows to segregate the supplementary data information from any other information.
    /// </summary>
    public class SupplementaryDataEnvelope1XmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<SupplementaryDataEnvelope1>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;SupplementaryDataEnvelope1&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, SupplementaryDataEnvelope1 value, string isoNamespace)
        {
            // Underlying library does not supply a property to write, implement later.
            // writer.WriteValue( value );
            return Task.CompletedTask;
        }
    }
}
