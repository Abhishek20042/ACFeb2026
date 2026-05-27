namespace Finance;

public static class LoanHelper
{
    public static decimal MonthlyInstallment(decimal loan, int years, float rate)
    {
        int m = 12 * years;
        float i = rate / 1200;
        double e = i / (1 - Math.Pow(1 + i, -m));
        return (decimal)e * loan;
    }
}