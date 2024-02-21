using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// This is the interface that transcends all levels of serialization.
/// Only the topmost document level that declares the namespace will not implement this.
/// It will instead be a consumer of it.
/// </summary>
/// <typeparam name="TValue">Data type of data being serialized.</typeparam>
public interface ISubordinateXmlAsyncWriter<TValue>
{
    Task WriteAsync(XmlWriter writer, TValue value, string isoNamespace);
}