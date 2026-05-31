using DemoApp.Models;

namespace DemoApp.Views;

public class PresentationLayer(IDataAccessLayer model)
{
    public void Render()
    {
        Console.WriteLine("Welcome Customer.");
        Console.Write("Item    : ");
        string name = Console.ReadLine().ToLower();
        Console.Write("Quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        var info = model.FetchItemInfo(name);
        if(quantity <= info.StockLevel)
        {
            Console.WriteLine("Total Payment: {0:0.00}", 1.05 * quantity * info.UnitCost);
        }
        else
            Console.WriteLine("Not available!");
    }
}