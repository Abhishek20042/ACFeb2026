using System.Net;
using System.Net.Sockets;

var store = new Dictionary<string, string>()
{
    ["chair"] = "COST is 4500.00 with STOCK of 50",
    ["desk"] = "COST is 3000.00 with STOCK of 40",
    ["cabinet"] = "COST is 2500.00 with STOCK of 30"
};

Console.WriteLine("Starting server on TCP port 4010...");
//Step 1
var listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
listener.Bind(new IPEndPoint(IPAddress.Any, 4010));
listener.Listen();
while(true)
{
    //Step 2
    var connection = listener.Accept();
    //Step 3
    //OnConnect(connection);
    new Thread(() => OnConnect(connection)).Start();
}

void OnConnect(Socket client)
{
    try
    {
        //Step 3a
        var remote = new NetworkStream(client);
        using var reader = new StreamReader(remote);
        using var writer = new StreamWriter(remote);
        //Step 3b
        writer.WriteLine("Welcome to MET-OFFICE supplies.");
        writer.Flush();
        string name = reader.ReadLine();
        if(store.TryGetValue(name, out string info))
        {
            writer.WriteLine(info);
            writer.Flush();
        }
    }
    catch(IOException ex)
    {
        Console.WriteLine("Communication Failure: {0}", ex.Message);
    }
    //Step 3c
    client.Close();
}


