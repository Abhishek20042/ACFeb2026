namespace Finance;

public class HomeLoan
{
    public float Common(decimal amount, int period) => amount < 5000000 ? 8.5f : 8.0f;

    public float Woman(decimal amount, int period) => Common(amount, period) - 1;

    [MaxDuration(Limit = 12)]
    public float Welfare(decimal amount, int period) => 0.6f * Common(amount, period);
    
}
