﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for DirectDebitMandate.  ISO2002 ID# _a4TwEdcZEeqRFcf2R4bPBw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.MandateRelatedData2Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.MandateRelatedData2Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="DirectDebitMandate"/>.
    /// </summary>
    public class MandateRelatedData2ChoiceDirectDebitMandateXmlAsyncWriter : ISubordinateXmlAsyncWriter<DirectDebitMandate>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max35TextXmlAsyncWriter mandateIdentification;
        private readonly ISODateXmlAsyncWriter dateOfSignature;
        private readonly TrueFalseIndicatorXmlAsyncWriter amendmentIndicator;
        private readonly ISubordinateXmlAsyncWriter<AmendmentInformationDetails14> amendmentInformationDetails;
        private readonly Max1025TextXmlAsyncWriter electronicSignature;
        private readonly ISODateXmlAsyncWriter firstCollectionDate;
        private readonly ISODateXmlAsyncWriter finalCollectionDate;
        private readonly ISubordinateXmlAsyncWriter<Frequency36Choice_> frequency;
        private readonly ISubordinateXmlAsyncWriter<MandateSetupReason1Choice_> reason;
        private readonly Exact2NumericTextXmlAsyncWriter trackingDays;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public MandateRelatedData2ChoiceDirectDebitMandateXmlAsyncWriter
        (
            Max35TextXmlAsyncWriter mandateIdentification,
            ISODateXmlAsyncWriter dateOfSignature,
            TrueFalseIndicatorXmlAsyncWriter amendmentIndicator,
            ISubordinateXmlAsyncWriter<AmendmentInformationDetails14> amendmentInformationDetails,
            Max1025TextXmlAsyncWriter electronicSignature,
            ISODateXmlAsyncWriter firstCollectionDate,
            ISODateXmlAsyncWriter finalCollectionDate,
            ISubordinateXmlAsyncWriter<Frequency36Choice_> frequency,
            ISubordinateXmlAsyncWriter<MandateSetupReason1Choice_> reason,
            Exact2NumericTextXmlAsyncWriter trackingDays
        )
        {
            this.mandateIdentification = mandateIdentification;
            this.dateOfSignature = dateOfSignature;
            this.amendmentIndicator = amendmentIndicator;
            this.amendmentInformationDetails = amendmentInformationDetails;
            this.electronicSignature = electronicSignature;
            this.firstCollectionDate = firstCollectionDate;
            this.finalCollectionDate = finalCollectionDate;
            this.frequency = frequency;
            this.reason = reason;
            this.trackingDays = trackingDays;
        }
        public async Task WriteAsync(XmlWriter writer, DirectDebitMandate valueBeingSerialized, string isoNamespace)
        {
            // MandateIdentification Optional Max35Text System.String
            if ( valueBeingSerialized.MandateIdentification is System.String populatedMandateIdentification)
            {
                await writer.WriteStartElementAsync(null, "MndtId", isoNamespace );
                await mandateIdentification.WriteAsync(writer, populatedMandateIdentification, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // DateOfSignature Optional ISODate System.DateOnly
            if ( valueBeingSerialized.DateOfSignature is System.DateOnly populatedDateOfSignature)
            {
                await writer.WriteStartElementAsync(null, "DtOfSgntr", isoNamespace );
                await dateOfSignature.WriteAsync(writer, populatedDateOfSignature, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // AmendmentIndicator Optional TrueFalseIndicator System.String
            if ( valueBeingSerialized.AmendmentIndicator is System.String populatedAmendmentIndicator)
            {
                await writer.WriteStartElementAsync(null, "AmdmntInd", isoNamespace );
                await amendmentIndicator.WriteAsync(writer, populatedAmendmentIndicator, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // AmendmentInformationDetails Optional AmendmentInformationDetails14 AmendmentInformationDetails14
            if ( valueBeingSerialized.AmendmentInformationDetails is AmendmentInformationDetails14 populatedAmendmentInformationDetails)
            {
                await writer.WriteStartElementAsync(null, "AmdmntInfDtls", isoNamespace );
                await amendmentInformationDetails.WriteAsync(writer, populatedAmendmentInformationDetails, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // ElectronicSignature Optional Max1025Text System.String
            if ( valueBeingSerialized.ElectronicSignature is System.String populatedElectronicSignature)
            {
                await writer.WriteStartElementAsync(null, "ElctrncSgntr", isoNamespace );
                await electronicSignature.WriteAsync(writer, populatedElectronicSignature, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // FirstCollectionDate Optional ISODate System.DateOnly
            if ( valueBeingSerialized.FirstCollectionDate is System.DateOnly populatedFirstCollectionDate)
            {
                await writer.WriteStartElementAsync(null, "FrstColltnDt", isoNamespace );
                await firstCollectionDate.WriteAsync(writer, populatedFirstCollectionDate, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // FinalCollectionDate Optional ISODate System.DateOnly
            if ( valueBeingSerialized.FinalCollectionDate is System.DateOnly populatedFinalCollectionDate)
            {
                await writer.WriteStartElementAsync(null, "FnlColltnDt", isoNamespace );
                await finalCollectionDate.WriteAsync(writer, populatedFinalCollectionDate, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Frequency Optional Frequency36Choice Frequency36Choice_
            if ( valueBeingSerialized.Frequency is Frequency36Choice_ populatedFrequency)
            {
                await writer.WriteStartElementAsync(null, "Frqcy", isoNamespace );
                await frequency.WriteAsync(writer, populatedFrequency, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Reason Optional MandateSetupReason1Choice MandateSetupReason1Choice_
            if ( valueBeingSerialized.Reason is MandateSetupReason1Choice_ populatedReason)
            {
                await writer.WriteStartElementAsync(null, "Rsn", isoNamespace );
                await reason.WriteAsync(writer, populatedReason, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // TrackingDays Optional Exact2NumericText System.String
            if ( valueBeingSerialized.TrackingDays is System.String populatedTrackingDays)
            {
                await writer.WriteStartElementAsync(null, "TrckgDays", isoNamespace );
                await trackingDays.WriteAsync(writer, populatedTrackingDays, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
