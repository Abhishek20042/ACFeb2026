using System;

class Program
{

    private static void Advise(ref Investment inv)
    {
        double amount = inv.TotalPayment();
        inv.AllowRisk(amount < 500000);
    }

    //a method can use a parameter qualified with 'out' keyword to accept
    //a reference to an uninitialized argument but then the method must
    //initialize such a parameter before it returns
    private static bool TryPremiumScheme(double installment, out Investment inv)
    {
        if(installment < 100000)
        {
            inv = new Investment();
            return false;
        }
        inv = new Investment(installment, 5);
        if(installment < 250000)
            inv.AllowRisk(RiskLevel.High);
        else
            inv.AllowRisk(RiskLevel.Low);
        return true;

    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome Investor!");
        double p = double.Parse(args[0]);
        int n = int.Parse(args[1]);
        Investment myinv = new Investment(p, n);
        Console.WriteLine("Future value in risk-free investment: {0:0.00}", myinv.FutureValue());
        myinv.AllowRisk(true);
        Console.WriteLine("Future value in low-risk investment: {0:0.00}", myinv.FutureValue());
        Advise(ref myinv); 
        Console.WriteLine("Future value in smart investment: {0:0.00}", myinv.FutureValue());
        if(n == 5 && TryPremiumScheme(p, out Investment prinv))
        {
            Console.WriteLine("Future value in premium investment: {0:0.00}", prinv.FutureValue());
        }
    }
}