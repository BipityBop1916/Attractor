namespace hw27.ex3;

public class Stack<T> : IDataVisualizer<T>
{
    private T[] items;
    private int _count;

    public Stack(int n = 10)
    {
        items = new T[n];
        _count = 0;
    }
    
    public void Push(T value)
    {
        if (_count >= items.Length)
        {
            Console.WriteLine("https://stackoverflow.com");
            return;
        }
        
        items[_count++] = value;
    }

    public T Pop()
    {
        if (_count == 0)
        {
            Console.WriteLine("Stack underflow");
            return default;
        }
        
        T value = items[--_count];
        items[_count] = default(T);
        
        return value;
    }

    public void ShowData()
    {
        for (int i = _count - 1; i >= 0; i--)
        {
            Console.WriteLine($"[{i}] {items[i]}");
        }

        if (_count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
    }
}