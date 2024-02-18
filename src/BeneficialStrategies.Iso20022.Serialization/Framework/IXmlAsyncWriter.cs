using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// To be implemented by serializers that only write to a single XML namespace and place the
/// contents of the message in an outer document in a ISO20022 prescribed manner.
/// This serializer knows it's xmlnamespace, it's root document name, and the name of the container that holds 
/// the message contents itself.
/// </summary>
/// <typeparam name="TValue">The message to be written.</typeparam>
public interface IXmlAsyncWriter<TValue>
{
    Task WriteAsync(XmlWriter writer, TValue value);
}
