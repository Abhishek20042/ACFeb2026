using DemoApp;

if(args.Length == 0)
{
    //var store = new List<Interval>();
    //var store = new HashSet<Interval>();
    var store = new SortedSet<Interval>();
    store.Add(new Interval(4, 31));
    store.Add(new Interval(6, 52));
    store.Add(new Interval(7, 13));
    store.Add(new Interval(3, 24));
    store.Add(new Interval(5, 45));
    store.Add(new Interval(2, 151));    
    foreach(var entry in store)
        Console.WriteLine(entry);
}
else
{
    //var store = new Dictionary<string, Interval>();
    //var store = new SortedList<string, Interval>();
    var store = new SortedDictionary<string, Interval>();
    store.Add("monday", new Interval(4, 31));
    store.Add("tuesday", new Interval(6, 52));
    store.Add("wednesday", new Interval(7, 13));
    store.Add("thursday", new Interval(3, 24));
    store["friday"] = new Interval(5, 45); //insert
    store["monday"] = new Interval(2, 31); //update
    if(store.TryGetValue(args[0], out var val))
    {
        Console.WriteLine("Interval = {0}", val);
    }
    else
    {
        foreach(var pair in store)
            Console.WriteLine("{0, -16}{1, 8}", pair.Key, pair.Value);
    }
}