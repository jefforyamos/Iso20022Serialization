using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// This will be the class from which most component serializers will inherit.
/// </summary>
/// <typeparam name="TParent">Data type of the item being serialized.</typeparam>
public abstract class ContainerXmlAsyncWriter<TParent> : ISubordinateXmlAsyncWriter<TParent>
{
    private readonly ISubordinateXmlAsyncWriter<TParent>[] memberWriters;

    protected ContainerXmlAsyncWriter(params ISubordinateXmlAsyncWriter<TParent>[] memberWriters)
    {
        this.memberWriters = memberWriters;
    }

    public async Task WriteAsync(XmlWriter writer, TParent value, string isoNamespace)
    {
        foreach( var memberWriter in memberWriters) await memberWriter.WriteAsync(writer,value,isoNamespace);
    }
}

