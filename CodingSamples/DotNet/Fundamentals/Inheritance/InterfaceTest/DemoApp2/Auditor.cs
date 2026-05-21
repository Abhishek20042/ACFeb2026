using DemoApp.Taxation;

namespace DemoApp;

class Auditor : IDisposable
{
    public Auditor()
    {
        Console.WriteLine("Auditor Log[{0}]: opening audit session...", DateTime.Now);
    }

    //optional parameters can appear at the end of the parameter list
    //each assigned with a constant-expression for its default argument
    public void Audit(string id, ITaxPayer info, decimal charges = 500)
    {
        Console.WriteLine($"Auditing {id} the {info.Profile}...");
        if(id.Length < 4)
            throw new ArgumentException("Invalid ID");
        decimal tax = info.IncomeTax();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Actual Tax: {0:0.00}", tax);
        Console.WriteLine("Audit Fees: {0:0.00}", charges);
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Total Payment: {0:0.00}", tax + charges);
        Console.WriteLine("-----------------------------");
    }

    public void Dispose()
    {
        Console.WriteLine("Auditor Log[{0}]: closing audit session...", DateTime.Now);
    }
}