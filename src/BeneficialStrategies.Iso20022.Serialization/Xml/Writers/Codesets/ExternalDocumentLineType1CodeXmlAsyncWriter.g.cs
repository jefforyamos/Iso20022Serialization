﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetSerializationGenerator for ExternalDocumentLineType1Code.  ISO2002 ID# _Nv6E4RtqEeOa4Kl-9PmHww.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Codesets
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="ExternalDocumentLineType1Code"/>.
    /// </summary>
    public class ExternalDocumentLineType1CodeXmlAsyncWriter : ISubordinateXmlAsyncWriter<ExternalDocumentLineType1Code>
    {
        public virtual async Task WriteAsync(XmlWriter writer, ExternalDocumentLineType1Code valueBeingSerialized, string isoNamespace)
        {
            var valueToWrite = valueBeingSerialized switch
            {
                ExternalDocumentLineType1Code.AdditionalProductIdentificationAssignedByTheManufacturer => "ADPI",
                ExternalDocumentLineType1Code.AlternateISBN => "AISB",
                ExternalDocumentLineType1Code.AssetNumber => "ASNB",
                ExternalDocumentLineType1Code.CatalogNumber => "CTNB",
                ExternalDocumentLineType1Code.DunBradstreetStandardProductAndServiceCode => "DBSP",
                ExternalDocumentLineType1Code.EuropeanArticleNumberEAN2551 => "EANN",
                ExternalDocumentLineType1Code.EquipmentIdentificationNumber => "EINB",
                ExternalDocumentLineType1Code.GeneralSpecificationNumber => "GSNB",
                ExternalDocumentLineType1Code.HIBCHealthCareIndustryBarCode => "HIBC",
                ExternalDocumentLineType1Code.InternationalStandardBookNumberISBN => "ISBN",
                ExternalDocumentLineType1Code.LotNumber => "LTNB",
                ExternalDocumentLineType1Code.ModelNumber => "MDNB",
                ExternalDocumentLineType1Code.PartNumber => "PRNB",
                ExternalDocumentLineType1Code.ProductTypeCode => "PTCD",
                ExternalDocumentLineType1Code.StockNumber => "SKNB",
                ExternalDocumentLineType1Code.StyleNumber => "STNB",
                ExternalDocumentLineType1Code.TechnicalOrderNumber => "TONB",
                ExternalDocumentLineType1Code.UPCConsumerPackageCode => "UPCC",
                ExternalDocumentLineType1Code.UniversalProductNumber => "UPNB",
                _ => "_"
            };
            await writer.WriteStringAsync(valueToWrite);
        }
    }
}
