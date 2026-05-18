class Program
{
	public static void Main(string[] args)
	{
		Investment.Greet();
		double p = double.Parse(args[0]);
		int n = int.Parse(args[1]);
		System.Console.WriteLine("Future value in basic investment: {0:0.00}", Investment.FutureValue(p, n));
	}
}

