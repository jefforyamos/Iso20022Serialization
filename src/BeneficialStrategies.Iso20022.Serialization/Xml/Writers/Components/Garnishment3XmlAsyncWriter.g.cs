﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for Garnishment3.  ISO2002 ID# __Cz88248EeiU9cctagi5ow.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Garnishment3"/>.
    /// </summary>
    public class Garnishment3XmlAsyncWriter : ISubordinateXmlAsyncWriter<Garnishment3>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<GarnishmentType1> type;
        private readonly ISubordinateXmlAsyncWriter<PartyIdentification135> garnishee;
        private readonly ISubordinateXmlAsyncWriter<PartyIdentification135> garnishmentAdministrator;
        private readonly Max140TextXmlAsyncWriter referenceNumber;
        private readonly ISODateXmlAsyncWriter date;
        private readonly ISubordinateXmlAsyncWriter<ActiveOrHistoricCurrencyAndAmount> remittedAmount;
        private readonly TrueFalseIndicatorXmlAsyncWriter familyMedicalInsuranceIndicator;
        private readonly TrueFalseIndicatorXmlAsyncWriter employeeTerminationIndicator;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public Garnishment3XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<GarnishmentType1> type,
            ISubordinateXmlAsyncWriter<PartyIdentification135> garnishee,
            ISubordinateXmlAsyncWriter<PartyIdentification135> garnishmentAdministrator,
            Max140TextXmlAsyncWriter referenceNumber,
            ISODateXmlAsyncWriter date,
            ISubordinateXmlAsyncWriter<ActiveOrHistoricCurrencyAndAmount> remittedAmount,
            TrueFalseIndicatorXmlAsyncWriter familyMedicalInsuranceIndicator,
            TrueFalseIndicatorXmlAsyncWriter employeeTerminationIndicator
        )
        {
            this.type = type;
            this.garnishee = garnishee;
            this.garnishmentAdministrator = garnishmentAdministrator;
            this.referenceNumber = referenceNumber;
            this.date = date;
            this.remittedAmount = remittedAmount;
            this.familyMedicalInsuranceIndicator = familyMedicalInsuranceIndicator;
            this.employeeTerminationIndicator = employeeTerminationIndicator;
        }
        public async Task WriteAsync(XmlWriter writer, Garnishment3 valueBeingSerialized, string isoNamespace)
        {
            // Type Required GarnishmentType1 GarnishmentType1
            await writer.WriteStartElementAsync(null, "Tp", isoNamespace );
            await type.WriteAsync(writer, valueBeingSerialized.Type, isoNamespace);
            await writer.WriteEndElementAsync();
            // Garnishee Optional PartyIdentification135 PartyIdentification135
            if ( valueBeingSerialized.Garnishee is PartyIdentification135 populatedGarnishee)
            {
                await writer.WriteStartElementAsync(null, "Grnshee", isoNamespace );
                await garnishee.WriteAsync(writer, populatedGarnishee, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // GarnishmentAdministrator Optional PartyIdentification135 PartyIdentification135
            if ( valueBeingSerialized.GarnishmentAdministrator is PartyIdentification135 populatedGarnishmentAdministrator)
            {
                await writer.WriteStartElementAsync(null, "GrnshmtAdmstr", isoNamespace );
                await garnishmentAdministrator.WriteAsync(writer, populatedGarnishmentAdministrator, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // ReferenceNumber Optional Max140Text System.String
            if ( valueBeingSerialized.ReferenceNumber is System.String populatedReferenceNumber)
            {
                await writer.WriteStartElementAsync(null, "RefNb", isoNamespace );
                await referenceNumber.WriteAsync(writer, populatedReferenceNumber, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Date Optional ISODate System.DateOnly
            if ( valueBeingSerialized.Date is System.DateOnly populatedDate)
            {
                await writer.WriteStartElementAsync(null, "Dt", isoNamespace );
                await date.WriteAsync(writer, populatedDate, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // RemittedAmount Optional ActiveOrHistoricCurrencyAndAmount ActiveOrHistoricCurrencyAndAmount
            if ( valueBeingSerialized.RemittedAmount is ActiveOrHistoricCurrencyAndAmount populatedRemittedAmount)
            {
                await writer.WriteStartElementAsync(null, "RmtdAmt", isoNamespace );
                await remittedAmount.WriteAsync(writer, populatedRemittedAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // FamilyMedicalInsuranceIndicator Optional TrueFalseIndicator System.String
            if ( valueBeingSerialized.FamilyMedicalInsuranceIndicator is System.String populatedFamilyMedicalInsuranceIndicator)
            {
                await writer.WriteStartElementAsync(null, "FmlyMdclInsrncInd", isoNamespace );
                await familyMedicalInsuranceIndicator.WriteAsync(writer, populatedFamilyMedicalInsuranceIndicator, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // EmployeeTerminationIndicator Optional TrueFalseIndicator System.String
            if ( valueBeingSerialized.EmployeeTerminationIndicator is System.String populatedEmployeeTerminationIndicator)
            {
                await writer.WriteStartElementAsync(null, "MplyeeTermntnInd", isoNamespace );
                await employeeTerminationIndicator.WriteAsync(writer, populatedEmployeeTerminationIndicator, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
