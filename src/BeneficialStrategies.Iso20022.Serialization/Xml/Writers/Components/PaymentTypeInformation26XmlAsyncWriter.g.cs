﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for PaymentTypeInformation26.  ISO2002 ID# _YPH8YXR0EeiH1ZOt2UD8vQ.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Components
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="PaymentTypeInformation26"/>.
    /// </summary>
    public class PaymentTypeInformation26XmlAsyncWriter : ISubordinateXmlAsyncWriter<PaymentTypeInformation26>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Priority2CodeXmlAsyncWriter instructionPriority;
        private readonly ISubordinateXmlAsyncWriter<ServiceLevel8Choice_> serviceLevel;
        private readonly ISubordinateXmlAsyncWriter<LocalInstrument2Choice_> localInstrument;
        private readonly ISubordinateXmlAsyncWriter<CategoryPurpose1Choice_> categoryPurpose;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public PaymentTypeInformation26XmlAsyncWriter
        (
            Priority2CodeXmlAsyncWriter instructionPriority,
            ISubordinateXmlAsyncWriter<ServiceLevel8Choice_> serviceLevel,
            ISubordinateXmlAsyncWriter<LocalInstrument2Choice_> localInstrument,
            ISubordinateXmlAsyncWriter<CategoryPurpose1Choice_> categoryPurpose
        )
        {
            this.instructionPriority = instructionPriority;
            this.serviceLevel = serviceLevel;
            this.localInstrument = localInstrument;
            this.categoryPurpose = categoryPurpose;
        }
        public async Task WriteAsync(XmlWriter writer, PaymentTypeInformation26 valueBeingSerialized, string isoNamespace)
        {
            // InstructionPriority Optional Priority2Code Priority2Code
            if ( valueBeingSerialized.InstructionPriority is Priority2Code populatedInstructionPriority)
            {
                await writer.WriteStartElementAsync(null, "InstrPrty", isoNamespace );
                await instructionPriority.WriteAsync(writer, populatedInstructionPriority, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // ServiceLevel Optional ServiceLevel8Choice ServiceLevel8Choice_
            if ( valueBeingSerialized.ServiceLevel is ServiceLevel8Choice_ populatedServiceLevel)
            {
                await writer.WriteStartElementAsync(null, "SvcLvl", isoNamespace );
                await serviceLevel.WriteAsync(writer, populatedServiceLevel, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // LocalInstrument Optional LocalInstrument2Choice LocalInstrument2Choice_
            if ( valueBeingSerialized.LocalInstrument is LocalInstrument2Choice_ populatedLocalInstrument)
            {
                await writer.WriteStartElementAsync(null, "LclInstrm", isoNamespace );
                await localInstrument.WriteAsync(writer, populatedLocalInstrument, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CategoryPurpose Optional CategoryPurpose1Choice CategoryPurpose1Choice_
            if ( valueBeingSerialized.CategoryPurpose is CategoryPurpose1Choice_ populatedCategoryPurpose)
            {
                await writer.WriteStartElementAsync(null, "CtgyPurp", isoNamespace );
                await categoryPurpose.WriteAsync(writer, populatedCategoryPurpose, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
