using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BeneficialStrategies.Iso20022.Serialization;
using WriterInterface = BeneficialStrategies.Iso20022.Serialization.IXmlAsyncWriter<BeneficialStrategies.Iso20022.pain.CustomerCreditTransferInitiationV11>;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.RegisterIso20022XmlSerializers();

var host = builder.Build();

var serializer = host.Services.GetRequiredService<WriterInterface>();

var myMessage = Sample.CustomerCreditTransferInitiationV11;

Console.WriteLine("Hello, World!");
