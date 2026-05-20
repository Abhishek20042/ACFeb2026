namespace Banking;

sealed class SavingsAccount : Account, IProfitable
{
    private const decimal MinBal = 5000;

    internal SavingsAccount()
    {
        Balance = MinBal;
    }

    public override void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if(Balance - amount < MinBal)
            throw new InsufficientFundsException();
        Balance -= amount;
    }

    public void AddInterest(int months)
    {
       decimal rate = Balance < 5 * MinBal ? 3.5m : 4.0m;
       decimal interest = Balance * months * rate / 1200;
       Balance += interest;
    }
}