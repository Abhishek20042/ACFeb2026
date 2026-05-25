using DemoApp.Shopping;

if (args[0] == "items")
{
    var items = Shop.GetItems()
        .Where(i => i.Brand == args[1])
        .Select(i => i.Name);
    foreach(var item in items)
        Console.WriteLine(item);
}
else if(args[0] == "customers")
{
    decimal min = decimal.Parse(args[1]);
    var customers = Shop.GetCustomers();
    customers.Add(new Customer("Xavier", 88000, 3));
    var selection = from c in customers
        where c.Purchase >= min
        orderby c.Id
        select new //creates instance of an anonymous type with specified properties
        {
            Name = c.Id,
            Stars = new string('*', c.Rating)
        };
    foreach(var entry in selection)
        Console.WriteLine($"{entry.Name}\t{entry.Stars}");
}