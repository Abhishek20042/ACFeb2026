struct Investment
{
    private double installment;
    private int years;
    private RiskLevel risk;

    public Investment(double payment, int count)
    {
        installment = payment;
        years = count;
        risk = RiskLevel.None;
    }

    public void AllowRisk(bool yes)
    {
        risk = yes ? RiskLevel.Low : RiskLevel.None;
    }

    //method overloading - defining a method whose name matches
    //with the name of another method but with different list
    //of parameter type
    public void AllowRisk(RiskLevel level)
    {
        risk = level;
    }

    public double TotalPayment()
    {
        return installment * years;
    }

    public double FutureValue()
    {
        float i;
        switch(risk)
        {
            case RiskLevel.Low:
                i = 0.08f;
                break;
            case RiskLevel.High:
                i = 0.11f;
                break;
            default:
                i = 0.06f;
                break;
        }
        return (installment / i) * (double.Pow(1 + i, years) - 1);
    }
}