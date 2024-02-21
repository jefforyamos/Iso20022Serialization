﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for GroupHeader95.  ISO2002 ID# _I9mVkcQKEemsic1bQcEtLA.
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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="GroupHeader95"/>.
    /// </summary>
    public class GroupHeader95XmlAsyncWriter : ISubordinateXmlAsyncWriter<GroupHeader95>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IMax35TextXmlAsyncWriter messageIdentification;
        private readonly IISODateTimeXmlAsyncWriter creationDateTime;
        private readonly ISubordinateXmlAsyncWriter<Authorisation1Choice_> authorisation;
        private readonly IMax15NumericTextXmlAsyncWriter numberOfTransactions;
        private readonly IDecimalNumberXmlAsyncWriter controlSum;
        private readonly ISubordinateXmlAsyncWriter<PartyIdentification135> initiatingParty;
        private readonly ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> forwardingAgent;
        private readonly ISubordinateXmlAsyncWriter<PaymentInitiationSource1> initiationSource;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public GroupHeader95XmlAsyncWriter
        (
            IMax35TextXmlAsyncWriter messageIdentification,
            IISODateTimeXmlAsyncWriter creationDateTime,
            ISubordinateXmlAsyncWriter<Authorisation1Choice_> authorisation,
            IMax15NumericTextXmlAsyncWriter numberOfTransactions,
            IDecimalNumberXmlAsyncWriter controlSum,
            ISubordinateXmlAsyncWriter<PartyIdentification135> initiatingParty,
            ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> forwardingAgent,
            ISubordinateXmlAsyncWriter<PaymentInitiationSource1> initiationSource
        )
        {
            this.messageIdentification = messageIdentification;
            this.creationDateTime = creationDateTime;
            this.authorisation = authorisation;
            this.numberOfTransactions = numberOfTransactions;
            this.controlSum = controlSum;
            this.initiatingParty = initiatingParty;
            this.forwardingAgent = forwardingAgent;
            this.initiationSource = initiationSource;
        }
        public async Task WriteAsync(XmlWriter writer, GroupHeader95 valueBeingSerialized, string isoNamespace)
        {
            // MessageIdentification Required Max35Text System.String
            await writer.WriteStartElementAsync(null, "MsgId", isoNamespace );
            await messageIdentification.WriteAsync(writer, valueBeingSerialized.MessageIdentification, isoNamespace);
            await writer.WriteEndElementAsync();
            // CreationDateTime Required ISODateTime System.DateTime
            await writer.WriteStartElementAsync(null, "CreDtTm", isoNamespace );
            await creationDateTime.WriteAsync(writer, valueBeingSerialized.CreationDateTime, isoNamespace);
            await writer.WriteEndElementAsync();
            // Authorisation Collection Authorisation1Choice Authorisation1Choice_
            foreach ( var item in valueBeingSerialized.Authorisation)
            {
                await writer.WriteStartElementAsync(null, "Authstn", isoNamespace );
                await authorisation.WriteAsync(writer, item , isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // NumberOfTransactions Required Max15NumericText System.String
            await writer.WriteStartElementAsync(null, "NbOfTxs", isoNamespace );
            await numberOfTransactions.WriteAsync(writer, valueBeingSerialized.NumberOfTransactions, isoNamespace);
            await writer.WriteEndElementAsync();
            // ControlSum Optional DecimalNumber System.UInt64
            if ( valueBeingSerialized.ControlSum is System.UInt64 populatedControlSum)
            {
                await writer.WriteStartElementAsync(null, "CtrlSum", isoNamespace );
                await controlSum.WriteAsync(writer, populatedControlSum, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // InitiatingParty Required PartyIdentification135 PartyIdentification135
            await writer.WriteStartElementAsync(null, "InitgPty", isoNamespace );
            await initiatingParty.WriteAsync(writer, valueBeingSerialized.InitiatingParty, isoNamespace);
            await writer.WriteEndElementAsync();
            // ForwardingAgent Optional BranchAndFinancialInstitutionIdentification6 BranchAndFinancialInstitutionIdentification6
            if ( valueBeingSerialized.ForwardingAgent is BranchAndFinancialInstitutionIdentification6 populatedForwardingAgent)
            {
                await writer.WriteStartElementAsync(null, "FwdgAgt", isoNamespace );
                await forwardingAgent.WriteAsync(writer, populatedForwardingAgent, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // InitiationSource Optional PaymentInitiationSource1 PaymentInitiationSource1
            if ( valueBeingSerialized.InitiationSource is PaymentInitiationSource1 populatedInitiationSource)
            {
                await writer.WriteStartElementAsync(null, "InitnSrc", isoNamespace );
                await initiationSource.WriteAsync(writer, populatedInitiationSource, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
