namespace DemoApp.Services.Common;

public interface ICommunicationLayer
{
    Task CommunicateAsync(StreamReader input, StreamWriter output);
}