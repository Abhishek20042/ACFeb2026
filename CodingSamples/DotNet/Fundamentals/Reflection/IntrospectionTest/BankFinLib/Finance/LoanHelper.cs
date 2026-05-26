namespace Finance;

public static class LoanHelper
{
    public static double MonthlyInstallment(double loan, int years, float rate)
    {
        int m = 12 * years;
        float i = rate / 1200;
        return loan * i / (1 - Math.Pow(1 + i, -m));
    }
}