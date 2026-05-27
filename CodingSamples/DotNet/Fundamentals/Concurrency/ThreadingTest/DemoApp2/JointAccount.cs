namespace DemoApp;

class JointAccount
{
    public int Balance { get; private set; }

    private static int Evaluate(int bal, int amt, int sgn)
    {
        Thread.Sleep(amt / 100); //pause current thread for specified number of milliseconds
        return bal + amt * sgn;
    }

    public bool Debit(int amount)
    {
        bool success = false;
        Monitor.Enter(this); //lock the monitor assigned to 'this' object
        try
        {
            if(Balance >= amount)
            {
                Balance = Evaluate(Balance, amount, -1);
                success = true;
            }
        }
        finally
        {
            Monitor.Exit(this); //unlock the monitor assigned 'this' object
        }
        return success;
    }

    public void Credit(int amount)
    {
        lock(this)
        {
            Balance = Evaluate(Balance, amount, 1);
            Monitor.Pulse(this); //signal the monitor assigned to 'this' object
        }
    }

    public bool DebitAfterCredit(int amount)
    {
        lock(this)
        {
            //unlock monitor assigned to 'this' object and wait
            //for some other thread to signal the monitor
            Monitor.Wait(this); 
            return Debit(amount);
        }
    }
}