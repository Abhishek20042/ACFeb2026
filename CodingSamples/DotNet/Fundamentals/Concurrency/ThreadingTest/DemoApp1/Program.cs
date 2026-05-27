namespace DemoApp;

class Program
{
    static void HandleJob(int jobId)
    {
        Console.WriteLine("Thread<{0}> has accepted job<{1}> for {2}", Thread.CurrentThread.ManagedThreadId, jobId, Activity.Client);
        Activity.Perform(jobId);
        Console.WriteLine("Thread<{0}> has finished job<{1}> for {2}", Environment.CurrentManagedThreadId, jobId, Activity.Client);
    }

    static void Main(string[] args)
    {
        int n = args.Length > 0 ? int.Parse(args[0]) : 1;
        var child = new Thread(() =>
        {
            Activity.Client = "Jack";
            HandleJob(n);
        });
        if(n > 10)
            child.IsBackground = true; //runtime does not wait for a background thread to exit
        child.Start();
        Activity.Client = "Jill";
        HandleJob(2);

    }
}
