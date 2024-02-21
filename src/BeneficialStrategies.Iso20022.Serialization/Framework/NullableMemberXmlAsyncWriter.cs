using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// This is the companion to the <seealso cref="MemberXmlAsyncWriter"/>, but specialized to nullable members.
/// If the value is populated, it writes the value.  If null, it does nothing.
/// </summary>
/// <typeparam name="T">Data type of the member.</typeparam>
[Obsolete]
public class NullableMemberXmlAsyncWriter<T> : ISubordinateXmlAsyncWriter<T?>
    where T : struct
{
    private readonly ISubordinateXmlAsyncWriter<T> nonNullableWriter;

    public NullableMemberXmlAsyncWriter(ISubordinateXmlAsyncWriter<T> nonNullableWriter)
    {
        this.nonNullableWriter = nonNullableWriter;
    }

    public async Task WriteAsync(XmlWriter writer, T? value, string isoNamespace)
    {
        if ( value is T populatedValue) await this.nonNullableWriter.WriteAsync(writer,populatedValue,isoNamespace);
    }
}

