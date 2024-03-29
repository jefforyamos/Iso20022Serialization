﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceSerializationGenerator for Other.  ISO2002 ID# _Pdwzo9p-Ed-ak6NoX_4Aeg_-1833657786.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Serialization.Xml.Codesets;
using BeneficialStrategies.Iso20022.Serialization.Xml.Writers.SimpleTypes;
using System.Xml;

using Other = BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.Other;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.Choices.AccountIdentification4Choice
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="Other"/>.
    /// </summary>
    public class AccountIdentification4ChoiceOtherXmlAsyncWriter : ISubordinateXmlAsyncWriter<Other>
    {
        // Injected dependencies for serialization of each member data type
        private readonly Max34TextXmlAsyncWriter identification;
        private readonly ISubordinateXmlAsyncWriter<AccountSchemeName1Choice_> schemeName;
        private readonly Max35TextXmlAsyncWriter issuer;
        
        /// <summary>
        /// Construct using an injected writer for each member.
        /// </summary>
        public AccountIdentification4ChoiceOtherXmlAsyncWriter
        (
            Max34TextXmlAsyncWriter identification,
            ISubordinateXmlAsyncWriter<AccountSchemeName1Choice_> schemeName,
            Max35TextXmlAsyncWriter issuer
        )
        {
            this.identification = identification;
            this.schemeName = schemeName;
            this.issuer = issuer;
        }
        public async Task WriteAsync(XmlWriter writer, Other valueBeingSerialized, string isoNamespace)
        {
            await writer.WriteStartElementAsync(null, "Othr", isoNamespace); // ConcreteChoiceIndicator
            // Identification Required Max34Text System.String
            await writer.WriteStartElementAsync(null, "Id", isoNamespace );
            await identification.WriteAsync(writer, valueBeingSerialized.Identification, isoNamespace);
            await writer.WriteEndElementAsync();
            // SchemeName Optional AccountSchemeName1Choice AccountSchemeName1Choice_
            if ( valueBeingSerialized.SchemeName is AccountSchemeName1Choice_ populatedSchemeName)
            {
                await writer.WriteStartElementAsync(null, "SchmeNm", isoNamespace );
                await schemeName.WriteAsync(writer, populatedSchemeName, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            // Issuer Optional Max35Text System.String
            if ( valueBeingSerialized.Issuer is System.String populatedIssuer)
            {
                await writer.WriteStartElementAsync(null, "Issr", isoNamespace );
                await issuer.WriteAsync(writer, populatedIssuer, isoNamespace);
                await writer.WriteEndElementAsync();
            }
            await writer.WriteEndElementAsync(); // Concrete choice indicator
        }
    }
}
