using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DemoApp.Services.Common;

//worker service - implements IHostedService (through BackgroundService)
public class TransportLayer(ILogger<TransportLayer> logging, IConfiguration config) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        int port = config.GetValue("Server:Port", 4010);
        logging.LogInformation(1000, "Starting server on TCP port {p}...", port);
    }
}