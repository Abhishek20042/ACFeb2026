namespace DemoApp.Shopping;

public static class Shop
{
    public static Item[] GetItems()
    {
        return [
            new Item("cpu", "intel"),
            new Item("ddr", "samsung"),
            new Item("motherboard", "intel"),
            new Item("cpu", "amd"),
            new Item("mouse", "logitech"),
            new Item("ssd", "sandisk"),
            new Item("keyboard", "logitech"),
            new Item("ssd", "samsung"),
            new Item("mouse", "microsoft"),
            new Item("monitor", "samsung")
        ];
    }

    public static ICollection<Customer> GetCustomers()
    {
        var customers = new List<Customer>();
        customers.Add(new Customer("Sandeep", 45000, 3));
        customers.Add(new Customer("Pratha", 60000, 4));
        customers.Add(new Customer("Ketan", 85000, 5));
        customers.Add(new Customer("Akash", 30000, 1));
        customers.Add(new Customer("Roshani", 55000, 2));
        customers.Add(new Customer("Gauri", 120000, 5));
        customers.Add(new Customer("Yash", 90000, 4));
        customers.Add(new Customer("Manoj", 40000, 3));
        customers.Add(new Customer("Nishant", 75000, 4));
        customers.Add(new Customer("Vivek", 25000, 2));
        return customers;
 
    }
}