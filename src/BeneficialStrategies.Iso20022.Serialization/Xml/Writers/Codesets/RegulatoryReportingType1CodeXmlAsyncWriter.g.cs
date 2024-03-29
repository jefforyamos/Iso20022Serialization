﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetSerializationGenerator for RegulatoryReportingType1Code.  ISO2002 ID# _ZbFYZtp-Ed-ak6NoX_4Aeg_-1577941174.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Codesets
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="RegulatoryReportingType1Code"/>.
    /// </summary>
    public class RegulatoryReportingType1CodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<RegulatoryReportingType1Code>
    {
        public virtual async Task WriteAsync(XmlWriter writer, RegulatoryReportingType1Code valueBeingSerialized, string isoNamespace)
        {
            var valueToWrite = valueBeingSerialized switch
            {
                RegulatoryReportingType1Code.Credit => "CRED",
                RegulatoryReportingType1Code.Debit => "DEBT",
                RegulatoryReportingType1Code.Both => "BOTH",
                _ => "_"
            };
            await writer.WriteStringAsync(valueToWrite);
        }
    }
}
