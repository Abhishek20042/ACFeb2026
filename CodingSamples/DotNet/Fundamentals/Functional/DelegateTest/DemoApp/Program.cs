namespace DemoApp;

class Program
{
    private static float SafeScheme(int count)
    {
        return count < 3 ? 6 : 7;
    }

    static void Main()
    {
        Console.Write("Installment    : ");
        double p = double.Parse(Console.ReadLine());
        Console.Write("Number of Years: ");
        int n = int.Parse(Console.ReadLine());
        var myinv = new Investment
        {
            Installment = p,
            Years = n
        };
        Console.WriteLine("Future value in riskless investment: {0:0.00}", myinv.FutureValue(SafeScheme)); //new Interest(SafeScheme)
        int m = 8;
        Console.WriteLine("Future value in riskful investment : {0:0.00}", myinv.FutureValue(y => m + 0.25f * y)); //passing lambda expression
    }
}
