using DemoApp.Services.Common;

namespace DemoApp.Services.Shopping;

public class InventoryLookup(IDataAccessLayer storeroom) : ICommunicationLayer
{

    public async Task CommunicateAsync(StreamReader input, StreamWriter output)
    {
        await output.WriteLineAsync("Welcome to MET-DIGITAL supplies.");
        string name = await input.ReadLineAsync();
        var info = storeroom.ReadItemInfo(name);
        if(info != null)
        {
            await output.WriteLineAsync($"COST is {info.Cost} with STOCK of {info.Stock}");
        }
    }
}