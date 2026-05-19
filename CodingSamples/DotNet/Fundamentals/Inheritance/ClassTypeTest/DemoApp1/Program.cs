using System;
using Payroll;

class Program
{
    private static void Appraise(Employee emp)
    {
        if(emp.Hours > 175)
            emp.HourlyRate *= 1.06f;
    }

    private static double Tax(Employee emp)
    {
        double i = emp.Income();
        return i > 10000 ? 0.15 * (i - 10000) : 0;
    }

    public static void Main()
    {
        Employee jack = new Employee();
        jack.Workdays = 23; //setting property: jack.set_Workdays(23)
        Console.WriteLine("Jack's Income is {0:0.00}", jack.Income());
        Console.WriteLine("Appraising Jack...");
        Appraise(jack);
        Console.WriteLine("Jack's new Income is {0:0.00}", jack.Income());
        //Appraise(null);
        Console.WriteLine("Jack's Tax is {0:0.00}", Tax(jack));
        SalesPerson jill = new SalesPerson(184, 53, 62000);
        Console.WriteLine("Jill's Income is {0:0.00}", jill.Income());
        Console.WriteLine("Jill's Tax is {0:0.00}", Tax(jill));
    }
}
