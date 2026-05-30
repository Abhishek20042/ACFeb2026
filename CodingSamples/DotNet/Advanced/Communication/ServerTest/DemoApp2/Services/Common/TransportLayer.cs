using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DemoApp.Services.Common;

//worker service - implements IHostedService (through BackgroundService)
public class TransportLayer(ILogger<TransportLayer> logging, IConfiguration config, ICommunicationLayer protocol) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        int port = config.GetValue("Server:Port", 4010);
        logging.LogInformation(1000, "Starting server on TCP port {p}...", port);
        //step 1
        var listener = new TcpListener(IPAddress.Any, port);
        listener.Start();
        while(!stoppingToken.IsCancellationRequested)
        {
            //step 2
            var connection = await listener.AcceptTcpClientAsync(stoppingToken);
            //step 3
            OnConnect(connection);
        }
    }

    private async void OnConnect(TcpClient client)
    {
        //step 3a
        var remote = client.GetStream();
        using var reader = new StreamReader(remote);
        using var writer = new StreamWriter(remote) { AutoFlush = true };
        try
        {
            //step 3b
            await protocol.CommunicateAsync(reader, writer);
        }
        catch(Exception ex)
        {
            logging.LogError(ex, "Communication failure");
        }
        //step 3c
        client.Close();
    }
}