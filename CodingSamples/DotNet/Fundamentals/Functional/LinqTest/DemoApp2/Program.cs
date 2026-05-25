using DemoApp.Models;

var model = new SupplierModel();
var suppliers = model.ReadSuppliers();
foreach(var s in suppliers.OrderByDescending(s => s.Quantity))
    Console.WriteLine("{0, -12}{1, -12}{2, 8}", s.Name, s.Item, s.Quantity);
if(args.Length > 0)
{
    int total = suppliers.Where(s => s.Item == args[0])
        .Sum(s => s.Quantity);
    Console.WriteLine();
    Console.WriteLine($"Total supply for {args[0]} is {total}");
}



