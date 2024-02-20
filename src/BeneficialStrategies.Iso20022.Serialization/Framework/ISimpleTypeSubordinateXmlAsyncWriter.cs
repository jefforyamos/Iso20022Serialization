namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// Should be extended by each primitive subordinate data type.
/// </summary>
/// <typeparam name="T">The struct that is primitive to this data type.</typeparam>
public interface ISimpleTypeSubordinateXmlAsyncWriter<T> : ISubordinateXmlAsyncWriter<T>
{

}
