﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for AdviceType1.  ISO2002 ID# _5ZNFsNolEembTrt_WixjyQ.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="AdviceType1"/>.
    /// </summary>
    public class AdviceType1XmlAsyncWriter : ISubordinateXmlAsyncWriter<AdviceType1>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<AdviceType1Choice_> creditAdvice;
        private readonly ISubordinateXmlAsyncWriter<AdviceType1Choice_> debitAdvice;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public AdviceType1XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<AdviceType1Choice_> creditAdvice,
            ISubordinateXmlAsyncWriter<AdviceType1Choice_> debitAdvice
        )
        {
            this.creditAdvice = creditAdvice;
            this.debitAdvice = debitAdvice;
        }
        public async Task WriteAsync(XmlWriter writer, AdviceType1 valueBeingSerialized, string isoNamespace)
        {
            // CreditAdvice Optional AdviceType1Choice AdviceType1Choice_
            if ( valueBeingSerialized.CreditAdvice is AdviceType1Choice_ populatedCreditAdvice)
            {
                await writer.WriteStartElementAsync(null, "CdtAdvc", isoNamespace );
                await creditAdvice.WriteAsync(writer, populatedCreditAdvice, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // DebitAdvice Optional AdviceType1Choice AdviceType1Choice_
            if ( valueBeingSerialized.DebitAdvice is AdviceType1Choice_ populatedDebitAdvice)
            {
                await writer.WriteStartElementAsync(null, "DbtAdvc", isoNamespace );
                await debitAdvice.WriteAsync(writer, populatedDebitAdvice, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
