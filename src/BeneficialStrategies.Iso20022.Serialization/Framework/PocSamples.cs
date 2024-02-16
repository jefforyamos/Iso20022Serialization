using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.pain;

namespace BeneficialStrategies.Iso20022.Serialization.Poc.Sample;


public class CustomerCreditTransferInitiationV11Serializer : ContainerXmlAsyncWriter<CustomerCreditTransferInitiationV11>
{
    public CustomerCreditTransferInitiationV11Serializer(
        // Dependency injection of subordinate writers
        ISubordinateXmlAsyncWriter<GroupHeader95> groupHeader95writer,
        ISubordinateXmlAsyncWriter<PaymentInstruction40> paymentInstructionWriter,
        ISubordinateXmlAsyncWriter<SupplementaryData1> supplementalWriter
    )
    : base( 
        new MemberXmlAsyncWriter<CustomerCreditTransferInitiationV11, GroupHeader95>
        ( 
                "Gphdr", 
                groupHeader95writer,
                parent => parent.GroupHeader
        ),
        new MemberXmlAsyncWriter<CustomerCreditTransferInitiationV11,PaymentInstruction40>
        (
                "PmtInstr",
                paymentInstructionWriter,
                parent => parent.PaymentInformation
        ),
        new MemberXmlAsyncWriter<CustomerCreditTransferInitiationV11,SupplementaryData1>
        (
            "Supp",
            supplementalWriter,
            parent => parent.SupplementaryData
        )
    )
    {
    }
}

