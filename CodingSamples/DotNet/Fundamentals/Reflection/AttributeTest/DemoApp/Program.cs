using System.Reflection;
using Finance;

namespace DemoApp;

using RateFunc = Func<decimal, int, float>;
//delegate float RateFunc(decimal amount, int period);

class Program
{
    static void Main(string[] args)
    {
        decimal p = decimal.Parse(args[0]);
        Type t = Type.GetType($"Finance.{args[1]},BankFinLib", true);
        decimal pf = t.IsDefined(typeof(FlexibleAttribute)) ? 0.005m * p : 0;
        object policy = Activator.CreateInstance(t); 
        MethodInfo scheme = t.GetMethod(args[2]);
        MaxDurationAttribute md = scheme.GetCustomAttribute<MaxDurationAttribute>();
        int m = md?.Limit ?? 10; //md != null ? md.Limit : 10;
        //verify method and locate implementation
        RateFunc rf = scheme.CreateDelegate<RateFunc>(policy);
        for(int n = 1; n <= m; ++n)
        {
            float r = rf(p, n); //dispatch call
            decimal emi = LoanHelper.MonthlyInstallment(p, n, r);
            Console.WriteLine("{0, -6}{1, 16:0.00}", n, emi);
        }
        Console.WriteLine("Processing Fees: {0:0.00}", pf);
    }
}
