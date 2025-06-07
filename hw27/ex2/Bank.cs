namespace hw27.ex2;

public class Bank<T> where T : Account
{
    private T[] _accounts;
    private int _count;

    public Bank(int n = 10)
    {
        _accounts = new T[n];
        _count = 0;
    }

    public void AddAccount(T account)
    {
        if (_count >= _accounts.Length)
        {
            Console.WriteLine("Bank is full. Cannot add more accounts.");
            return;
        }

        _accounts[_count] = account;
        _count++;
    }

    public void ShowAccountInfo()
    {
        for (int i = 0; i < _count; i++)
        {
            _accounts[i].ShowInfo();
        }
    }
}

