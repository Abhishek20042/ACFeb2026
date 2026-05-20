namespace Banking;

//a class defined with static keyword can only
//define static members as it does not support
//an instance constructor
public static class Banker
{
    private static int count = 0;

    public static Account OpenCurrentAccount()
    {
        //implicitly typed local (inferred from initializer)
        var acc = new CurrentAccount();
        acc.Id = ++count + 100000000;
        return acc;
    }

    public static Account OpenSavingsAccount()
    {
        //target type (inferred from declaration) new expression
        SavingsAccount acc = new();
        acc.Id = ++count + 200000000;
        return acc;
    }

    //extension method - it is a member of a static class whose first parameter
    //is qualified with 'this' keyword so that it can called as an instance
    //method of its first parameter type by using namespace of the class in
    //which it is defined
    public static bool Transfer(this Account source, decimal amount, Account target)
    {
        if(ReferenceEquals(source, target))
            return false;
        source.Withdraw(amount);
        target.Deposit(amount);
        return true;
    }
}