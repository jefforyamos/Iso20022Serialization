using System.Xml;

namespace BeneficialStrategies.Iso20022.Serialization;

/// <summary>
/// One of these is initialized inside each container for each member of that container.  
/// It is responsible for writing the contents of the specified member in ISO20022 standard format.
/// </summary>
/// <typeparam name="TParent">Data type of the parent.</typeparam>
/// <typeparam name="TMember">Data type of the member.</typeparam>
public class MemberXmlAsyncWriter<TParent, TMember> : ISubordinateXmlAsyncWriter<TParent>
{
    private readonly string elementName;
    private readonly ISubordinateXmlAsyncWriter<TMember> dataStateWriter;
    private readonly Func<TParent, TMember?> propertyGetter;

    public MemberXmlAsyncWriter(string elementName, ISubordinateXmlAsyncWriter<TMember> dataStateWriter, Func<TParent,TMember?> propertyGetter)
    {
        this.elementName = elementName;
        this.dataStateWriter = dataStateWriter;
        this.propertyGetter = propertyGetter;
    }

    public async Task WriteAsync(XmlWriter writer, TParent parent, string isoNamespace)
    {
        var optionalValue = propertyGetter(parent);
        if ( optionalValue is TMember nonNullValue)
        {
            await writer.WriteStartElementAsync(null, this.elementName,isoNamespace);
            await dataStateWriter.WriteAsync(writer, nonNullValue, isoNamespace);
            await writer.WriteEndElementAsync();
        }
    }
}

