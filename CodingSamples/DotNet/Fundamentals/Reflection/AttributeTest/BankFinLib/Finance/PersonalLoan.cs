namespace Finance;

[Flexible]
public class PersonalLoan
{
    [MaxDuration(6)]
    public virtual float Common(decimal amount, int period) => 10 + 0.5f * (period / 3);

    public float Employee(decimal amount, int period) => 0.5f * Common(amount, period);
}
