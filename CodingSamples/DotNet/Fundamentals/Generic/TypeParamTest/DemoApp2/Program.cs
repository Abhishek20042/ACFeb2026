namespace DemoApp;

class Program
{
    static void PrintStack(SimpleStack<string> store)
    {
        while(!store.Empty())
            Console.WriteLine(store.Pop());
    }

    static void PrintStack(SimpleStack<Interval> store)
    {
        while(!store.Empty())
            Console.WriteLine(store.Pop());
    }

    static void Main(string[] args)
    {
        //closed generic type with string for type-parameter
        SimpleStack<string> a = new SimpleStack<string>();
        a.Push("Monday");
        a.Push("Tuesday");
        a.Push("Wednesday");
        a.Push("Thursday");
        a.Push("Friday");
        //a.Push(12.3);
        PrintStack(a);
        SimpleStack<Interval> b = new SimpleStack<Interval>();
        b.Push(new Interval(4, 31));
        b.Push(new Interval(7, 12));
        b.Push(new Interval(6, 53));
        b.Push(new Interval(5, 24));
        Console.WriteLine("--------------------------");
        PrintStack(b);
    }
}
