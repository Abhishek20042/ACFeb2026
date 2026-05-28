using System.Diagnostics;

namespace DemoApp;

class Computation
{
    private Stopwatch clock = new();

    private static long Evaluate(int count)
    {
        SpinWait.SpinUntil(() => false, 100 * count); //Thread.Sleep(100 * count);
        return count * count;
    }

    public long Compute(int lower, int upper)
    {
        clock.Start();
        return Enumerable.Range(lower, upper - lower + 1)
            .AsParallel() //split sequence into subsequences which can
            .Select(Evaluate) //be executed on separate processors/cores
            .Sum();
    }

    public Task<long> ComputeAsync(int lower, int upper)
    {
        return Task<long>.Run(() => Compute(lower, upper));
    }

    public double Time()
    {
        clock.Stop();
        return clock.Elapsed.TotalSeconds;
    }
}
