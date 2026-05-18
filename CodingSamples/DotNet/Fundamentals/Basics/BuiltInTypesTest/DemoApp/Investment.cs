class Investment
{

	//a method defined with static keyword in a type must be directly 
	//called on that type and as such it can only refer to other
	//static members of that type
	public static double FutureValue(double installment, int years)
	{
		float i = 0.06f;
		return (installment / i) * (double.Pow(1 + i, years) - 1);
	}

	public static void Greet() 
	{
		System.Console.WriteLine("Welcome Investor.");
	}

}

