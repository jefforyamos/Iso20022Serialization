using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BeneficialStrategies.Iso20022.Serialization;
using WriterInterface = BeneficialStrategies.Iso20022.Serialization.IXmlAsyncWriter<BeneficialStrategies.Iso20022.pain.CustomerCreditTransferInitiationV11>;
using System.Xml;
using System.Diagnostics;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.RegisterIso20022XmlSerializers();

var host = builder.Build();

var serializer = host.Services.GetRequiredService<WriterInterface>();

var myMessage = Sample.CustomerCreditTransferInitiationV11;
var fileName = $@"{myMessage.GetType().Name}.gen.xml";
using var writer = XmlWriter.Create(fileName, new XmlWriterSettings { Indent = true , Async = true });
await serializer.WriteAsync(writer, myMessage);
writer.Close();

Console.WriteLine("View output!");
