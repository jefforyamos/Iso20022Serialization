﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for StructuredRemittanceInformation17.  ISO2002 ID# _n5V1sd4lEeqt1ZcLzWyWFw.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="StructuredRemittanceInformation17"/>.
    /// </summary>
    public class StructuredRemittanceInformation17XmlAsyncWriter : ISubordinateXmlAsyncWriter<StructuredRemittanceInformation17>
    {
        // Injected dependencies for serialization of each member data type
        private readonly ISubordinateXmlAsyncWriter<ReferredDocumentInformation7> referredDocumentInformation;
        private readonly ISubordinateXmlAsyncWriter<RemittanceAmount2> referredDocumentAmount;
        private readonly ISubordinateXmlAsyncWriter<CreditorReferenceInformation2> creditorReferenceInformation;
        private readonly ISubordinateXmlAsyncWriter<PartyIdentification135> invoicer;
        private readonly ISubordinateXmlAsyncWriter<PartyIdentification135> invoicee;
        private readonly ISubordinateXmlAsyncWriter<TaxData1> taxRemittance;
        private readonly ISubordinateXmlAsyncWriter<Garnishment3> garnishmentRemittance;
        private readonly Max140TextXmlAsyncWriter additionalRemittanceInformation;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public StructuredRemittanceInformation17XmlAsyncWriter
        (
            ISubordinateXmlAsyncWriter<ReferredDocumentInformation7> referredDocumentInformation,
            ISubordinateXmlAsyncWriter<RemittanceAmount2> referredDocumentAmount,
            ISubordinateXmlAsyncWriter<CreditorReferenceInformation2> creditorReferenceInformation,
            ISubordinateXmlAsyncWriter<PartyIdentification135> invoicer,
            ISubordinateXmlAsyncWriter<PartyIdentification135> invoicee,
            ISubordinateXmlAsyncWriter<TaxData1> taxRemittance,
            ISubordinateXmlAsyncWriter<Garnishment3> garnishmentRemittance,
            Max140TextXmlAsyncWriter additionalRemittanceInformation
        )
        {
            this.referredDocumentInformation = referredDocumentInformation;
            this.referredDocumentAmount = referredDocumentAmount;
            this.creditorReferenceInformation = creditorReferenceInformation;
            this.invoicer = invoicer;
            this.invoicee = invoicee;
            this.taxRemittance = taxRemittance;
            this.garnishmentRemittance = garnishmentRemittance;
            this.additionalRemittanceInformation = additionalRemittanceInformation;
        }
        public async Task WriteAsync(XmlWriter writer, StructuredRemittanceInformation17 valueBeingSerialized, string isoNamespace)
        {
            // ReferredDocumentInformation Optional ReferredDocumentInformation7 ReferredDocumentInformation7
            if ( valueBeingSerialized.ReferredDocumentInformation is ReferredDocumentInformation7 populatedReferredDocumentInformation)
            {
                await writer.WriteStartElementAsync(null, "RfrdDocInf", isoNamespace );
                await referredDocumentInformation.WriteAsync(writer, populatedReferredDocumentInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // ReferredDocumentAmount Optional RemittanceAmount2 RemittanceAmount2
            if ( valueBeingSerialized.ReferredDocumentAmount is RemittanceAmount2 populatedReferredDocumentAmount)
            {
                await writer.WriteStartElementAsync(null, "RfrdDocAmt", isoNamespace );
                await referredDocumentAmount.WriteAsync(writer, populatedReferredDocumentAmount, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CreditorReferenceInformation Optional CreditorReferenceInformation2 CreditorReferenceInformation2
            if ( valueBeingSerialized.CreditorReferenceInformation is CreditorReferenceInformation2 populatedCreditorReferenceInformation)
            {
                await writer.WriteStartElementAsync(null, "CdtrRefInf", isoNamespace );
                await creditorReferenceInformation.WriteAsync(writer, populatedCreditorReferenceInformation, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Invoicer Optional PartyIdentification135 PartyIdentification135
            if ( valueBeingSerialized.Invoicer is PartyIdentification135 populatedInvoicer)
            {
                await writer.WriteStartElementAsync(null, "Invcr", isoNamespace );
                await invoicer.WriteAsync(writer, populatedInvoicer, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Invoicee Optional PartyIdentification135 PartyIdentification135
            if ( valueBeingSerialized.Invoicee is PartyIdentification135 populatedInvoicee)
            {
                await writer.WriteStartElementAsync(null, "Invcee", isoNamespace );
                await invoicee.WriteAsync(writer, populatedInvoicee, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // TaxRemittance Optional TaxData1 TaxData1
            if ( valueBeingSerialized.TaxRemittance is TaxData1 populatedTaxRemittance)
            {
                await writer.WriteStartElementAsync(null, "TaxRmt", isoNamespace );
                await taxRemittance.WriteAsync(writer, populatedTaxRemittance, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // GarnishmentRemittance Optional Garnishment3 Garnishment3
            if ( valueBeingSerialized.GarnishmentRemittance is Garnishment3 populatedGarnishmentRemittance)
            {
                await writer.WriteStartElementAsync(null, "GrnshmtRmt", isoNamespace );
                await garnishmentRemittance.WriteAsync(writer, populatedGarnishmentRemittance, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // AdditionalRemittanceInformation Collection Max140Text System.String
            foreach ( var item in valueBeingSerialized.AdditionalRemittanceInformation)
            {
                await writer.WriteStartElementAsync(null, "AddtlRmtInf", isoNamespace );
                await additionalRemittanceInformation.WriteAsync(writer, item , isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
