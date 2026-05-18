//user-defined value type
struct Investment
{
    //instance fields
    private double installment;
    private int years;
    private bool risk;

    //constructor
    public Investment(double payment, int count)
    {
        installment = payment;
        years = count;
        risk = false;
    }

    //instance (non-static) method of a type must be called on an
    //instance of that type which is passed to the method as 'this'
    //argument through which it can refer to any (static or non-static)
    //member of that type
    public void AllowRisk(bool yes)
    {
        risk = yes;
    }

    public double TotalPayment()
    {
        return installment * years;
    }

    public double FutureValue()
    {
        float i = risk ? 0.08f : 0.06f;
        return (installment / i) * (double.Pow(1 + i, years) - 1);
    }
}