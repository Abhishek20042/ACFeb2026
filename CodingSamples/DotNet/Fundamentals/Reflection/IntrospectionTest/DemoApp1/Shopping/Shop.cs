namespace DemoApp.Shopping;

public static class Shop
{
    public static Item PopularItem { get; } = new Item("cpu", "intel");

    public static Customer BestCustomer { get; } = new Customer("Jack", 200000, 5);
    
}