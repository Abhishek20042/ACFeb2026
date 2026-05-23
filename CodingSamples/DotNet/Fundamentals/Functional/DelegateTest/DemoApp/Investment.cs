delegate float Interest(int period);

class Investment
{
    public double Installment { get; init; } = 50000;

    //a property defined with 'required' keyword 
    //must be set in the initializer 
    public required int Years { get; init; }

    public double FutureValue(Interest rate)
    {
        float i = rate(Years) / 100; //rate.Invoke(Years)
        return (Installment / i) * (Math.Pow(1 + i, Years) - 1);
    }
}
