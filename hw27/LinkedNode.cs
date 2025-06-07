using System.Diagnostics.Contracts;

namespace hw27;

public class MyLinkedList<T>
{
    private LinkedNode<T> _first;
    private LinkedNode<T> _last;
    private int _count;
    
    public LinkedNode<T> First => _first;
    public LinkedNode<T> Last => _last;
    public int Count => _count;

    public MyLinkedList()
    {
        _first = null;
        _last = null;
        _count = 0;
    }

    public void Add(T value)
    {
        LinkedNode<T> newNode = new LinkedNode<T>(value);
        _count++;

        if (_first == null)
        {
            _first = _last = newNode;
        }
        else
        {
            _last.Next = newNode;
            newNode.Previous = _last;
            _last = newNode;
        }
    }
}

public class LinkedNode<T>
{
    public T Value { get; set; }
    public LinkedNode<T> Next { get; set; }
    public LinkedNode<T> Previous { get; set; }

    public LinkedNode(T value)
    {
        Value = value;
        Next = null;
        Previous = null;
    }
}