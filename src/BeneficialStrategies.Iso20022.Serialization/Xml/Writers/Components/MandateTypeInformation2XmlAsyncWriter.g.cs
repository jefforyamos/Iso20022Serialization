﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for MandateTypeInformation2.  ISO2002 ID# _cm369kjwEeaVLL5QKJ4f-A.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="MandateTypeInformation2"/>.
    /// </summary>
    public class MandateTypeInformation2XmlAsyncWriter
    ( // primary constructor 
        ISubordinateXmlAsyncWriter<ServiceLevel8Choice_> serviceLevel,
        ISubordinateXmlAsyncWriter<LocalInstrument2Choice_> localInstrument,
        ISubordinateXmlAsyncWriter<CategoryPurpose1Choice_> categoryPurpose,
        ISubordinateXmlAsyncWriter<MandateClassification1Choice_> classification
    ) // end primary constructor
            : ISubordinateXmlAsyncWriter<MandateTypeInformation2>
    {
        public async Task WriteAsync(XmlWriter writer, MandateTypeInformation2 value, string isoNamespace)
        {
            // ServiceLevel Optional ServiceLevel8Choice ServiceLevel8Choice_
            if ( value.ServiceLevel is ServiceLevel8Choice_ populatedServiceLevel)
            {
                await writer.WriteStartElementAsync(null, "SvcLvl", isoNamespace );
                await serviceLevel.WriteAsync(writer, populatedServiceLevel, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // LocalInstrument Optional LocalInstrument2Choice LocalInstrument2Choice_
            if ( value.LocalInstrument is LocalInstrument2Choice_ populatedLocalInstrument)
            {
                await writer.WriteStartElementAsync(null, "LclInstrm", isoNamespace );
                await localInstrument.WriteAsync(writer, populatedLocalInstrument, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CategoryPurpose Optional CategoryPurpose1Choice CategoryPurpose1Choice_
            if ( value.CategoryPurpose is CategoryPurpose1Choice_ populatedCategoryPurpose)
            {
                await writer.WriteStartElementAsync(null, "CtgyPurp", isoNamespace );
                await categoryPurpose.WriteAsync(writer, populatedCategoryPurpose, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Classification Optional MandateClassification1Choice MandateClassification1Choice_
            if ( value.Classification is MandateClassification1Choice_ populatedClassification)
            {
                await writer.WriteStartElementAsync(null, "Clssfctn", isoNamespace );
                await classification.WriteAsync(writer, populatedClassification, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
