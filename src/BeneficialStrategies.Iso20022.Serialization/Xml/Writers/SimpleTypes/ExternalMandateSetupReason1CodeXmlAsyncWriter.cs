﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by SimpleTypeInteraceForExternalCodesetsGenerator for ExternalMandateSetupReason1Code.  ISO2002 ID# _hsQScD2MEeS6DKIV6SF6gw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes
{
    /// <summary>
    /// Implemented by the provider of serialization for this data type.
    /// This is declared to serialize on behalf of the codeset named &apos;ExternalMandateSetupReason1Code&apos; which does not relate to an enum value,
    /// but is instead maintaned externally. Details:
    /// Specifies the external mandate setup reason code in the format of character string with a maximum length of 4 characters.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    public class ExternalMandateSetupReason1CodeXmlAsyncWriter : ISimpleTypeSubordinateXmlAsyncWriter<System.String>
    {
        
        // Create a constructor with an injected logger if contents are modified during serialization.
        
        /// <summary>
        /// Write the value to the output the way ISO20022 says a &apos;ExternalMandateSetupReason1Code&apos; should be formatted.
        /// Coerce the value when possible or truncate text that is too long.
        /// Can be overridden by subclass with inheritance.
        /// </summary>
        public virtual Task WriteAsync(XmlWriter writer, string value, string isoNamespace)
        {
            // If changes are made to the serialized output, be sure and create a debug log entry.
            writer.WriteValue( value );
            return Task.CompletedTask;
        }
    }
}
