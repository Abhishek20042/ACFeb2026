namespace DemoApp.Taxation;

public struct Supervisor(int subordinates) : ITaxPayer
{
    public string Profile { get; } = "Manager";

    decimal ITaxPayer.AnnualIncome()
    {
        return 480000 + 3000 * subordinates;
    }
}