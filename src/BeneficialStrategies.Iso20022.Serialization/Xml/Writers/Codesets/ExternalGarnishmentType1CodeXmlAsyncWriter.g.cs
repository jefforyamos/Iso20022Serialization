﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetSerializationGenerator for ExternalGarnishmentType1Code.  ISO2002 ID# _DsFkYInoEeOORMXOfBk1Bw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Codesets
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="ExternalGarnishmentType1Code"/>.
    /// </summary>
    public class ExternalGarnishmentType1CodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<ExternalGarnishmentType1Code>
    {
        public virtual async Task WriteAsync(XmlWriter writer, ExternalGarnishmentType1Code valueBeingSerialized, string isoNamespace)
        {
            var valueToWrite = valueBeingSerialized switch
            {
                ExternalGarnishmentType1Code.GarnishmentForChildSupport => "GNCS",
                ExternalGarnishmentType1Code.GarnishmentForChildSupportFromDirectPayer => "GNDP",
                ExternalGarnishmentType1Code.GarnishmentToTaxingAgency => "GTPP",
                _ => "_"
            };
            await writer.WriteStringAsync(valueToWrite);
        }
    }
}
