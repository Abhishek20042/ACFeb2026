using System.Xml.Linq;

namespace DemoApp.Models;

public class SupplierModel
{
    public List<Supplier> ReadOldSuppliers()
    {
        return File.ReadAllLines("suppliers.csv")
            .Skip(1)
            .Select(line => line.Split(','))
            .Select(segments => new Supplier //using primary constructor
            (
                Name: segments[0],
                Item: segments[1],
                Quantity: int.Parse(segments[2])
            ))
            .ToList();

    }

    public List<Supplier> ReadSuppliers()
    {
        var document = XElement.Load("suppliers.xml");
        var selection = from e in document.Elements("Supplier")
            select new Supplier //using initializer (not supported for class record)
            {
                Name = (string) e.Attribute("Id"),
                Item = (string) e.Element("Component"),
                Quantity = (int) e.Element("Stock")
            };
        return selection.ToList();
    }
}