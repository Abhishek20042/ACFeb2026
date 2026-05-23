using DemoApp;
var a = new SimpleStack<string>();
a.Push("Monday");
a.Push("Tuesday");
a.Push("Wednesday");
a.Push("Thursday");
a.Push("Friday");
for(var e = a.GetEnumerator(); e.MoveNext();)
    Console.WriteLine(e.Current);
a[2] = "Holiday"; //using indexer
Console.WriteLine("------------------------");
while(!a.Empty())
    Console.WriteLine(a.Pop());
SimpleStack<double> b = new();
b.Push(47.1);
b.Push(53.2);
b.Push(65.3);
b.Push(31.4);
Console.WriteLine("------------------------");
foreach(double d in b)
    Console.WriteLine(d);
var c = Interval.Generate(6);
Console.WriteLine("------------------------");
foreach(Interval i in c)
{
    Console.WriteLine(i);
    if(i.Minutes == 2)
        break;
}
