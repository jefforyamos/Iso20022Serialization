﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetSerializationGenerator for AddressType2Code.  ISO2002 ID# _bm2sYNp-Ed-ak6NoX_4Aeg_595056355.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Codesets
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="AddressType2Code"/>.
    /// </summary>
    public class AddressType2CodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<AddressType2Code>
    {
        public virtual async Task WriteAsync(XmlWriter writer, AddressType2Code valueBeingSerialized, string isoNamespace)
        {
            var valueToWrite = valueBeingSerialized switch
            {
                AddressType2Code.Postal => "ADDR",
                AddressType2Code.POBox => "PBOX",
                AddressType2Code.Residential => "HOME",
                AddressType2Code.Business => "BIZZ",
                AddressType2Code.MailTo => "MLTO",
                AddressType2Code.DeliveryTo => "DLVY",
                _ => "_"
            };
            await writer.WriteStringAsync(valueToWrite);
        }
    }
}
