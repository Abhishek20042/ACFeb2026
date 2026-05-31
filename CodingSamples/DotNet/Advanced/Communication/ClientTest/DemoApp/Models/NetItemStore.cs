using System.Net.Sockets;

namespace DemoApp.Models;

public class NetItemStore(string host) : IDataAccessLayer
{
    public ItemInfo FetchItemInfo(string id)
    {
        //step 1
        using var connection = new TcpClient(host, 4020);
        //step 2a
        var remote = connection.GetStream();
        using var reader = new StreamReader(remote);
        using var writer = new StreamWriter(remote) { AutoFlush = true };
        //step 2b
        reader.ReadLine(); //read and ignore greeting message
        writer.WriteLine(id);
        string reply = reader.ReadLine();
        if(reply != null)
        {
            string[] segments = reply.Split(' ');
            return new ItemInfo
            {
                UnitCost = double.Parse(segments[2]),
                StockLevel = int.Parse(segments[6])
            };
        }
        return new ItemInfo();
        //Step 2c - connection will be closed through Dispose
    }
}