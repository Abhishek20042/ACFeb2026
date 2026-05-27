namespace Finance;

public class CarLoan : PersonalLoan
{
    public override float Common(decimal amount, int period)
    {
        return (amount < 1000000 ? 11 : 12) + (period > 3 ? 1 : 0);
    }
}