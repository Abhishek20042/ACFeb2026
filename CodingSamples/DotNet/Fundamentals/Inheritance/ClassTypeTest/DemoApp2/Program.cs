//top-level statements can be used in one source file of a project
//with OutputType=Exe, compiler copies these statements into the Main
//method of an auto-generated class

Interval a = new Interval(5, 20);
Print("Interval a", a);
Interval b = new Interval(3, 45);
Print("Interval b", b);
Interval c = new Interval(4, 80);
Print("Interval c", c);
Interval d = b;
Print("Interval d", d);
Print("Sum of a and b", a + b);
Console.WriteLine("------------------------------");
Console.WriteLine("a is identical to b: {0}", ReferenceEquals(a, b));
Console.WriteLine("a is identical to c: {0}", ReferenceEquals(a, c));
Console.WriteLine("d is identical to b: {0}", ReferenceEquals(d, b));
Console.WriteLine("------------------------------");
Console.WriteLine("a is equal to b: {0}", a.GetHashCode() == b.GetHashCode() && a.Equals(b));
Console.WriteLine("a is equal to c: {0}", a.GetHashCode() == c.GetHashCode() && a.Equals(c)); 
Console.WriteLine("d is equal to b: {0}", Equals(d, b)); //using System.Object.Equals method which performs above operations
Console.WriteLine("------------------------------");
Banner e = new Banner { Width = 12.75f, Height = 4.25f }; //instance initializer syntax
//automatic boxing - converting value-type data into an identity of reference type
Print("Banner e", e);

//local function of Main, such a function cannot be overloaded
void Print(string label, object info)
{
    Console.WriteLine("{0} = {1}", label, info.ToString());
}
