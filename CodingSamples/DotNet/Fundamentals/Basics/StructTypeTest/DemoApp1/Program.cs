using System;

class Program
{
    //a method can use a parameter qualified with 'ref' keyword
    //to accept a reference (verifiable address) to an initialized
    //argument, this reference automatically indirects to the
    //value of passed argument
    private static void Advise(ref Investment inv)
    {
        double amount = inv.TotalPayment();
        inv.AllowRisk(amount < 500000);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome Investor!");
        double p = double.Parse(args[0]);
        int n = int.Parse(args[1]);
        Investment myinv = new Investment(p, n);
        Console.WriteLine("Future value in risk-free investment: {0:0.00}", myinv.FutureValue());
        myinv.AllowRisk(true);
        Console.WriteLine("Future value in riskful investment: {0:0.00}", myinv.FutureValue());
        Advise(ref myinv); //passing reference using 'ref' operator
        Console.WriteLine("Future value in smart investment: {0:0.00}", myinv.FutureValue());
    }
}