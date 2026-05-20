namespace Banking;

//a class defined with 'abstract' keyword
//cannot be activated
public abstract class Account
{
    public long Id { get; internal set; }

    public decimal Balance { get; protected set; }

    //a method defined with 'abstract' keyword must
    //be overridden in the derived class
    public abstract void Deposit(decimal amount);

    public abstract void Withdraw(decimal amount);
}
