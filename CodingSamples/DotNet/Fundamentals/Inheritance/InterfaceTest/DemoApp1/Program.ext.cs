using Banking;

//different portions of same type can be defined in separate source files
//using 'partial' keyword, this approach is commonly used to define
//additional members for an auto-generated type
partial class Program
{
    //a method can accept variable number of arguments of a particular type
    //through its last array type parameter qualified with 'params' keyword
    private static void PayQuarterlyInterest(int quarters, params Account[] accounts)
    {
        foreach(Account acc in accounts)
        {
            //type-casting a reference type using 'as' operator which
            //return null if the instance referred by source cannot
            //be converted to target type
            IProfitable p = acc as IProfitable;
            p?.AddInterest(3 * quarters); //if(p != null) p.AddInterest(3 * quarters);
        }
    }
}