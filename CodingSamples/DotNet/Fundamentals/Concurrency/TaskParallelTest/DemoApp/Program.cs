namespace DemoApp;

class Program
{
    static async Task DoComputing(int limit)
    {
        Console.Write("Computing...");
        var c = new Computation();
        long r = await c.ComputeAsync(1, limit);
        Console.WriteLine("Done!");
        Console.WriteLine("Result = {0}, computed in {1:0.000} seconds.", r, c.Time());
    }

    static void Main(string[] args)
    {
        int n = int.Parse(args[0]);
        var job = DoComputing(n);
        while(!job.IsCompleted)
        {
            Console.Write('.');
            Thread.Sleep(500);
        }
    }
}
