﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentSerializationGenerator for GroupHeader88.  ISO2002 ID# _aHxYAW49EeiU9cctagi5ow.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

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
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="GroupHeader88"/>.
    /// </summary>
    public class GroupHeader88XmlAsyncWriter : ISubordinateXmlAsyncWriter<GroupHeader88>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max35TextXmlAsyncWriter messageIdentification;
        private readonly ISODateTimeXmlAsyncWriter creationDateTime;
        private readonly ISubordinateXmlAsyncWriter<Authorisation1Choice_> authorisation;
        private readonly Max15NumericTextXmlAsyncWriter numberOfTransactions;
        private readonly DecimalNumberXmlAsyncWriter controlSum;
        private readonly TrueFalseIndicatorXmlAsyncWriter groupReversal;
        private readonly ISubordinateXmlAsyncWriter<PartyIdentification135> initiatingParty;
        private readonly ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> forwardingAgent;
        private readonly ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> debtorAgent;
        private readonly ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> creditorAgent;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public GroupHeader88XmlAsyncWriter
        (
            Max35TextXmlAsyncWriter messageIdentification,
            ISODateTimeXmlAsyncWriter creationDateTime,
            ISubordinateXmlAsyncWriter<Authorisation1Choice_> authorisation,
            Max15NumericTextXmlAsyncWriter numberOfTransactions,
            DecimalNumberXmlAsyncWriter controlSum,
            TrueFalseIndicatorXmlAsyncWriter groupReversal,
            ISubordinateXmlAsyncWriter<PartyIdentification135> initiatingParty,
            ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> forwardingAgent,
            ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> debtorAgent,
            ISubordinateXmlAsyncWriter<BranchAndFinancialInstitutionIdentification6> creditorAgent
        )
        {
            this.messageIdentification = messageIdentification;
            this.creationDateTime = creationDateTime;
            this.authorisation = authorisation;
            this.numberOfTransactions = numberOfTransactions;
            this.controlSum = controlSum;
            this.groupReversal = groupReversal;
            this.initiatingParty = initiatingParty;
            this.forwardingAgent = forwardingAgent;
            this.debtorAgent = debtorAgent;
            this.creditorAgent = creditorAgent;
        }
        public async Task WriteAsync(XmlWriter writer, GroupHeader88 valueBeingSerialized, string isoNamespace)
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
            // GroupReversal Optional TrueFalseIndicator System.String
            if ( valueBeingSerialized.GroupReversal is System.String populatedGroupReversal)
            {
                await writer.WriteStartElementAsync(null, "GrpRvsl", isoNamespace );
                await groupReversal.WriteAsync(writer, populatedGroupReversal, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // InitiatingParty Optional PartyIdentification135 PartyIdentification135
            if ( valueBeingSerialized.InitiatingParty is PartyIdentification135 populatedInitiatingParty)
            {
                await writer.WriteStartElementAsync(null, "InitgPty", isoNamespace );
                await initiatingParty.WriteAsync(writer, populatedInitiatingParty, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // ForwardingAgent Optional BranchAndFinancialInstitutionIdentification6 BranchAndFinancialInstitutionIdentification6
            if ( valueBeingSerialized.ForwardingAgent is BranchAndFinancialInstitutionIdentification6 populatedForwardingAgent)
            {
                await writer.WriteStartElementAsync(null, "FwdgAgt", isoNamespace );
                await forwardingAgent.WriteAsync(writer, populatedForwardingAgent, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // DebtorAgent Optional BranchAndFinancialInstitutionIdentification6 BranchAndFinancialInstitutionIdentification6
            if ( valueBeingSerialized.DebtorAgent is BranchAndFinancialInstitutionIdentification6 populatedDebtorAgent)
            {
                await writer.WriteStartElementAsync(null, "DbtrAgt", isoNamespace );
                await debtorAgent.WriteAsync(writer, populatedDebtorAgent, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // CreditorAgent Optional BranchAndFinancialInstitutionIdentification6 BranchAndFinancialInstitutionIdentification6
            if ( valueBeingSerialized.CreditorAgent is BranchAndFinancialInstitutionIdentification6 populatedCreditorAgent)
            {
                await writer.WriteStartElementAsync(null, "CdtrAgt", isoNamespace );
                await creditorAgent.WriteAsync(writer, populatedCreditorAgent, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
