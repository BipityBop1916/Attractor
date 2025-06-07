namespace hw27.ex2;

public class Account
{
    public int Id { get; set; }
    public decimal Balance { get; set; }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Account #{Id} - Balance: {Balance}");
    }
}

public class DepositAccount : Account
{
    public override void ShowInfo()
    {
        Console.WriteLine($"[Deposit] #{Id} - Balance: {Balance}");
    }
}

public class TransitAccount : Account
{
    public override void ShowInfo()
    {
        Console.WriteLine($"[Transit] #{Id} - Balance: {Balance}");
    }
}

public class ClosedAccount : Account
{
    public override void ShowInfo()
    {
        Console.WriteLine($"[Closed] #{Id} - Balance: {Balance} (closed)");
    }
}
