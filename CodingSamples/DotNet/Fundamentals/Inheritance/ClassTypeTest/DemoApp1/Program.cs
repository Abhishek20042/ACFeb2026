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
        //every instance contains a handle to the method-table of
        //the type from which it was initialized (by new operator)
        //and invocation of any virtual method is dispatched through
        //this table (dynamic binding)
        double i = emp.Income();
        return i > 10000 ? 0.15 * (i - 10000) : 0;
    }

    private static double Bonus(Employee? emp)
    {
        if(emp == null || emp is SalesPerson)
            return 0;
        return 0.05 * emp.Income();
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
        Console.WriteLine("Jack's Tax is {0:0.00} and Bonus is {1:0.00}", Tax(jack), Bonus(jack));
        SalesPerson jill = new SalesPerson(184, 53, 62000);
        Console.WriteLine("Jill's Income is {0:0.00}", jill.Income());
        Console.WriteLine("Jill's Tax is {0:0.00} and Bonus is {1:0.00}", Tax(jill), Bonus(jill));
        Console.WriteLine("Null Bonus: {0}", Bonus(null));
    }
}
