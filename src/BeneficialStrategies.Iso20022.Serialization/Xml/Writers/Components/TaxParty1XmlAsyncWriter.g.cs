﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for TaxParty1.  ISO2002 ID# _PdBMxtp-Ed-ak6NoX_4Aeg_-1937885674.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="TaxParty1"/>.
    /// </summary>
    public class TaxParty1XmlAsyncWriter
    ( // primary constructor 
        IMax35TextXmlAsyncWriter taxIdentification,
        IMax35TextXmlAsyncWriter registrationIdentification,
        IMax35TextXmlAsyncWriter taxType
    ) // end primary constructor
            : ISubordinateXmlAsyncWriter<TaxParty1>
    {
        public async Task WriteAsync(XmlWriter writer, TaxParty1 value, string isoNamespace)
        {
            // TaxIdentification Optional Max35Text System.String
            if ( value.TaxIdentification is System.String populatedTaxIdentification)
            {
                await writer.WriteStartElementAsync(null, "TaxId", isoNamespace );
                await taxIdentification.WriteAsync(writer, populatedTaxIdentification, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // RegistrationIdentification Optional Max35Text System.String
            if ( value.RegistrationIdentification is System.String populatedRegistrationIdentification)
            {
                await writer.WriteStartElementAsync(null, "RegnId", isoNamespace );
                await registrationIdentification.WriteAsync(writer, populatedRegistrationIdentification, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // TaxType Optional Max35Text System.String
            if ( value.TaxType is System.String populatedTaxType)
            {
                await writer.WriteStartElementAsync(null, "TaxTp", isoNamespace );
                await taxType.WriteAsync(writer, populatedTaxType, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
