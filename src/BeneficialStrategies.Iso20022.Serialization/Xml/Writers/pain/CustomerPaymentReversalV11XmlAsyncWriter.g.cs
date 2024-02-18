﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainComponentSerializerGenerator for CustomerPaymentReversalV11.  ISO2002 ID# _rUXm6dcBEeq_l4BJLVUF2Q.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pain;
using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization.Xml.Writers.pain
{
    /// <summary>
    /// Performs the XML serialization faithful to ISO20002 standards for <seealso cref="CustomerPaymentReversalV11"/>.
    /// </summary>
    public class CustomerPaymentReversalV11XmlAsyncWriter : ContainerXmlAsyncWriter<CustomerPaymentReversalV11>
            , ISubordinateXmlAsyncWriter<CustomerPaymentReversalV11>
            , IXmlAsyncWriter<CustomerPaymentReversalV11>
    {
        public CustomerPaymentReversalV11XmlAsyncWriter(
            
            // Injected dependencies
            
            ISubordinateXmlAsyncWriter<GroupHeader88> groupHeader,
            ISubordinateXmlAsyncWriter<OriginalGroupHeader16> originalGroupInformation,
            ISubordinateXmlAsyncWriter<OriginalPaymentInstruction41> originalPaymentInformationAndReversal,
            ISubordinateXmlAsyncWriter<SupplementaryData1> supplementaryData
        )
        : base (
            
            // Initalizing constituent members
            
                new MemberXmlAsyncWriter<CustomerPaymentReversalV11,GroupHeader88>
                (
                    "GrpHdr",
                    groupHeader,
                    parent => parent.GroupHeader
                ),
                
                new MemberXmlAsyncWriter<CustomerPaymentReversalV11,OriginalGroupHeader16>
                (
                    "OrgnlGrpInf",
                    originalGroupInformation,
                    parent => parent.OriginalGroupInformation
                ),
                
                new MemberXmlAsyncWriter<CustomerPaymentReversalV11,OriginalPaymentInstruction41>
                (
                    "OrgnlPmtInfAndRvsl",
                    originalPaymentInformationAndReversal,
                    parent => parent.OriginalPaymentInformationAndReversal
                ),
                
                new MemberXmlAsyncWriter<CustomerPaymentReversalV11,SupplementaryData1>
                (
                    "SplmtryData",
                    supplementaryData,
                    parent => parent.SupplementaryData
                )
                
        )
        {
            // Constructor logic in base class
        }
        
        /// <summary>
        /// Writes the specified <seealso cref="CustomerPaymentReversalV11"/> message in ISO20022 compliant format.
        /// Uses the conventions specified in constants in the message itself.
        /// </summary>
        /// <param name="writer">Xml writer to write to. Must have async enabled.</param>
        /// <param name="message">The message with the contents to be serialized.</param>
        /// <returns>The async task that writes the message.</returns>
        public async Task WriteAsync( XmlWriter writer, CustomerPaymentReversalV11 message )
        {
            await writer.WriteStartElementAsync( null, 
                CustomerPaymentReversalV11.DocumentElementName,
                CustomerPaymentReversalV11.DocumentNamespace);
            await writer.WriteStartElementAsync( null, CustomerPaymentReversalV11.XmlTag, CustomerPaymentReversalV11.DocumentNamespace );
            await this.WriteAsync(writer, message, CustomerPaymentReversalV11.DocumentNamespace); // Use subordinate interface to write contents
            await writer.WriteEndElementAsync(); // end of message
            await writer.WriteEndElementAsync(); // end of document
        }
    }
}
