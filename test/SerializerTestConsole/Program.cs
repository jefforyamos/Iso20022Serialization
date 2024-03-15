using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BeneficialStrategies.Iso20022.Serialization;
using WriterInterface = BeneficialStrategies.Iso20022.Serialization.IXmlAsyncWriter<BeneficialStrategies.Iso20022.pain.CustomerCreditTransferInitiationV11>;
using System.Xml;
using System.Diagnostics;
using BeneficialStrategies.Iso20022.SchemaValidation;
using System.Xml.Linq;
using System.Xml.Schema;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.RegisterIso20022XmlSerializers();

var host = builder.Build();

var serializer = host.Services.GetRequiredService<WriterInterface>();

var myMessage = Sample.CustomerCreditTransferInitiationV11;

var fileName = $@"{myMessage.GetType().Name}.gen.xml";
var errorsFileName = $@"{myMessage.GetType().Name}.errors.txt";

using var writer = XmlWriter.Create(fileName, new XmlWriterSettings { Indent = true , Async = true });
await serializer.WriteAsync(writer, myMessage);
writer.Close();

var xdoc = XDocument.Load(fileName);
Iso20022SchemaSet iso20022SchemaSet = new();

using ( var errorWriter = new StreamWriter(errorsFileName))
{
    errorWriter.WriteLine($@"Validation of {fileName}");
    xdoc.Validate(iso20022SchemaSet, (obj, eventArgs) => 
            { 
                errorWriter.WriteLine("".PadLeft(200, '='));
                errorWriter.WriteLine( $@"Object:   {obj}"); 
                errorWriter.WriteLine( $@"Severity: {eventArgs.Severity}");
                errorWriter.WriteLine( $@"Error:    {eventArgs.Exception}");
                errorWriter.WriteLine( $@"Message:  {eventArgs.Message}");
            });
}

Console.WriteLine("View output!");
