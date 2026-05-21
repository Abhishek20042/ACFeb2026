using DemoApp.Taxation;

namespace DemoApp;

class Program
{
    static void DoAuditing(string name, int count)
    {
        //a local variable whose type implements IDisposable
        //supports using statement/qualifier so that Dispose() 
        //is automatically called on this variable at the end 
        //of its scope
        using(var a = new Auditor())
        {
            if(count <= 10)
                a.Audit(name, new Supervisor(count), 750);
            else
                a.Audit(name, new Worker(count));
        }
        
    }

    static void Main(string[] args)
    {
        try
        {
            string m = args[0].ToUpper();
            int n = int.Parse(args[1]);
            DoAuditing(m, n);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }
}
