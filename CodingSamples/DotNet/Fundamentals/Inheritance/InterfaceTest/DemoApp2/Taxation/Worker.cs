namespace DemoApp.Taxation;

public struct Worker(int jobs) : ITaxPayer
{
    public string Profile {  get; } = "Laborer";

    //explicit interface implementation - it enables a type to provide
    //a private implementation for a method it inherits from an interface
    //using interface-qualified name for the method, such an implementation
    //can only be called through an identifier of that interface type
    decimal ITaxPayer.AnnualIncome()
    {
        return 180000 + 400 * jobs;
    }
}