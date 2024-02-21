﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetSerializationGenerator for AdviceType1Code.  ISO2002 ID# _U8Z8ANomEembTrt_WixjyQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Codesets
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="AdviceType1Code"/>.
    /// </summary>
    public class AdviceType1CodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<AdviceType1Code>
    {
        public virtual async Task WriteAsync(XmlWriter writer, AdviceType1Code valueBeingSerialized, string isoNamespace)
        {
            var valueToWrite = valueBeingSerialized switch
            {
                AdviceType1Code.AdviceWithDetails => "ADWD",
                AdviceType1Code.AdviceWithoutDetails => "ADND",
                _ => "_"
            };
            await writer.WriteStringAsync(valueToWrite);
        }
    }
}