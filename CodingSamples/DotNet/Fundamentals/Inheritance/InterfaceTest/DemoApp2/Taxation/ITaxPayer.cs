namespace DemoApp.Taxation;

public interface ITaxPayer
{
    string Profile { get; }

    decimal AnnualIncome();

    //default interface method - is an implicitly virtual method
    //defined with a specific implementation in an interface, such
    //a method can only be applied to this interface type and not
    //to its inheriting type unless it overrides that method
    decimal IncomeTax()
    {
        decimal e = AnnualIncome() - 120000;
        return e > 0 ? 0.15m * e : 0; 
    }
}
