namespace Finance;

public class HomeLoan
{
    public double Common(double amount, int period) => amount < 5000000 ? 8.5f : 8.0f;
}
