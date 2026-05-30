using DemoApp.Services.Common;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<TransportLayer>();
var app = builder.Build();
app.Run();

