using System.Runtime.InteropServices;

namespace DemoApp;

class Program
{
    [DllImport("dijkstra", EntryPoint = "lcm")]
    extern static nint LeastMultiple(nint first, nint second);

    static void Main(string[] args)
    {
        nint m = nint.Parse(args[0]);
        nint n = int.Parse(args[1]);
        Console.WriteLine("L.C.M = {0}", LeastMultiple(m, n));
    }
}
