﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetSerializationGenerator for PreferredContactMethod1Code.  ISO2002 ID# _6UHyApqlEeGSON8vddiWzQ_1788250895.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Codesets
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="PreferredContactMethod1Code"/>.
    /// </summary>
    public class PreferredContactMethod1CodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<PreferredContactMethod1Code>
    {
        public virtual async Task WriteAsync(XmlWriter writer, PreferredContactMethod1Code valueBeingSerialized, string isoNamespace)
        {
            var valueToWrite = valueBeingSerialized switch
            {
                PreferredContactMethod1Code.Letter => "LETT",
                PreferredContactMethod1Code.Email => "MAIL",
                PreferredContactMethod1Code.Phone => "PHON",
                PreferredContactMethod1Code.Fax => "FAXX",
                PreferredContactMethod1Code.MobileOrCellPhone => "CELL",
                _ => "_"
            };
            await writer.WriteStringAsync(valueToWrite);
        }
    }
}