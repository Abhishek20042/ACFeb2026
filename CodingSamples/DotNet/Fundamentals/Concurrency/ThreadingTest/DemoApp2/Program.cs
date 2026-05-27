using DemoApp;

var acc = new JointAccount();
acc.Credit(10000);
Console.WriteLine("Account opened for Jack and Jill.");
Console.WriteLine("Initial balance: {0}", acc.Balance);
var first = new Thread(() =>
{
    Console.WriteLine("Jack is withdrawing 6000...");
    if(acc.Debit(6000) == false)
        Console.WriteLine("Jack's transaction failed!");
});
var second = new Thread(() =>
{
    Console.WriteLine("Jill is withdrawing 7000...");
    if(acc.Debit(7000) == false)
        Console.WriteLine("Jill's transaction failed!");
});
first.Start();
second.Start();
first.Join(); //current (main) thread waits for first to exit
second.Join();
Console.WriteLine("Final balance  : {0}", acc.Balance);

