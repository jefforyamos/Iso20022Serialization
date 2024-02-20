﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for OtherContact1.  ISO2002 ID# _6SokSZqlEeGSON8vddiWzQ_1969673172.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Components
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="OtherContact1"/>.
    /// </summary>
    public class OtherContact1XmlAsyncWriter
    ( // primary constructor 
        IMax4TextXmlAsyncWriter channelType,
        IMax128TextXmlAsyncWriter identification
    ) // end primary constructor
            : ISubordinateXmlAsyncWriter<OtherContact1>
    {
        public async Task WriteAsync(XmlWriter writer, OtherContact1 value, string isoNamespace)
        {
            // ChannelType Required Max4Text System.String
            await writer.WriteStartElementAsync(null, "ChanlTp", isoNamespace );
            await channelType.WriteAsync(writer, value.ChannelType, isoNamespace);
            await writer.WriteEndElementAsync();
            // Identification Optional Max128Text System.String
            if ( value.Identification is System.String populatedIdentification)
            {
                await writer.WriteStartElementAsync(null, "Id", isoNamespace );
                await identification.WriteAsync(writer, populatedIdentification, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
