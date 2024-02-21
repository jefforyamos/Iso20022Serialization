﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for OrganisationIdentification.  ISO2002 ID# _6VWvQ248EeiU9cctagi5ow.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.Party38Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.Party38Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="OrganisationIdentification"/>.
    /// </summary>
    public class Party38ChoiceOrganisationIdentificationXmlAsyncWriter : ISubordinateXmlAsyncWriter<OrganisationIdentification>
    {
        // Injected dependencies for serialization of each member data type
        private readonly IAnyBICDec2014IdentifierXmlAsyncWriter anyBIC;
        private readonly ILEIIdentifierXmlAsyncWriter lEI;
        private readonly ISubordinateXmlAsyncWriter<GenericOrganisationIdentification1> other;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public Party38ChoiceOrganisationIdentificationXmlAsyncWriter
        (
            IAnyBICDec2014IdentifierXmlAsyncWriter anyBIC,
            ILEIIdentifierXmlAsyncWriter lEI,
            ISubordinateXmlAsyncWriter<GenericOrganisationIdentification1> other
        )
        {
            this.anyBIC = anyBIC;
            this.lEI = lEI;
            this.other = other;
        }
        public async Task WriteAsync(XmlWriter writer, OrganisationIdentification valueBeingSerialized, string isoNamespace)
        {
            // AnyBIC Optional AnyBICDec2014Identifier System.String
            if ( valueBeingSerialized.AnyBIC is System.String populatedAnyBIC)
            {
                await writer.WriteStartElementAsync(null, "AnyBIC", isoNamespace );
                await anyBIC.WriteAsync(writer, populatedAnyBIC, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // LEI Optional LEIIdentifier System.String
            if ( valueBeingSerialized.LEI is System.String populatedLEI)
            {
                await writer.WriteStartElementAsync(null, "LEI", isoNamespace );
                await lEI.WriteAsync(writer, populatedLEI, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Other Optional GenericOrganisationIdentification1 GenericOrganisationIdentification1
            if ( valueBeingSerialized.Other is GenericOrganisationIdentification1 populatedOther)
            {
                await writer.WriteStartElementAsync(null, "Othr", isoNamespace );
                await other.WriteAsync(writer, populatedOther, isoNamespace);
                await writer.WriteEndElementAsync();
            }
        }
    }
}
