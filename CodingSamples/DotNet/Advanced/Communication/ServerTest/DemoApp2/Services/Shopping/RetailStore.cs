using System.Text.Json;

namespace DemoApp.Services.Shopping;

public class RetailStore : IDataAccessLayer
{
    private ItemInfo[] items;

    public RetailStore()
    {
        using var document = new FileStream("data/retail.json", FileMode.Open);
        items = JsonSerializer.Deserialize<ItemInfo[]>(document);
    }

    public ItemInfo ReadItemInfo(string name)
    {
        return items.FirstOrDefault(entry => entry.Id == name);
    }

    public void WriteItemInfo(ItemInfo item)
    {
        var entries = items.ToList();
        entries.Add(item);
        using var document = new FileStream("data/retail.json", FileMode.Create);
        JsonSerializer.Serialize(document, entries);
    }
}