namespace DemoApp;

class Program
{
    //defining generic Select with type-parameter T
    static T Select<T>(int choice, T first, T second)
    {
        if((choice % 2) == 1)
            return first;
        return second;
    }

    static T Select<T>(T first, T second) where T: IComparable<T>
    {
        //if(first.GetHashCode() > second.GetHashCode())
        if(first.CompareTo(second) > 0)
            return first;
        return second;
    }

    static void Main(string[] args)
    {
        if(args.Length > 0)
        {
            int s = int.Parse(args[0]);
            string ss = Select(s, "Sunday", "Monday");
            Console.WriteLine($"Selected string value = {ss}");
            double sd = Select(s, 4.75, 7.25);
            Console.WriteLine($"Selected double value = {sd}");
            //double ssd = Select(s, "April", 5.5);
        }
        else
        {
            string ss = Select("Sunday", "Monday");
            Console.WriteLine($"Selected string value = {ss}");
            double sd = Select(4.75, 7.25);
            Console.WriteLine($"Selected double value = {sd}"); 
            Interval si = Select(new Interval(4, 30), new Interval(3, 45));
            Console.WriteLine($"Selected Interval value = {si}");      
        }
    }
}