namespace hw27;

public class MyLinkedList<T>
{
    private LinkedNode<T>? _first;
    private LinkedNode<T>? _last;
    private int _count;

    public LinkedNode<T>? First => _first;
    public LinkedNode<T>? Last => _last;
    public int Count => _count;

    public MyLinkedList()
    {
        _first = null;
        _last = null;
        _count = 0;
    }

    public void AddFirst(T value)
    {
        LinkedNode<T> newNode = new LinkedNode<T>(value);
        _count++;

        if (_first == null)
        {
            _first = _last = newNode;
        }
        else
        {
            _first.Previous = newNode;
            newNode.Next = _first;
            _first = newNode;
        }
    }

    public void AddFirst(LinkedNode<T> newNode)
    {
        _count++;

        if (_first == null)
        {
            _first = _last = newNode;
        }
        else
        {
            _first.Previous = newNode;
            newNode.Next = _first;
            _first = newNode;
            newNode.Previous = null;
        }
    }

    public void AddLast(T value)
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

    public void AddLast(LinkedNode<T> newNode)
    {
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
            newNode.Next = null;
        }
    }

    public void AddBefore(LinkedNode<T> oldNode, T value)
    {
        LinkedNode<T> newNode = new LinkedNode<T>(value);
        _count++;

        if (oldNode == null)
        {
            throw new ArgumentNullException(nameof(oldNode));
        }

        newNode.Next = oldNode;
        newNode.Previous = oldNode.Previous;
        
        if (oldNode.Previous != null)
        {
            oldNode.Previous.Next = newNode;
        }
        else
        {
            _first = newNode;
        }
        
        oldNode.Previous = newNode;
    }

    public void AddBefore(LinkedNode<T> oldNode, LinkedNode<T> newNode)
    {
        _count++;

        if (oldNode == null)
        {
            throw new ArgumentNullException(nameof(oldNode));
        }
        if (newNode == null)
        {
            throw new ArgumentNullException(nameof(newNode));
        }

        newNode.Next = oldNode;
        newNode.Previous = oldNode.Previous;
        
        if (oldNode.Previous != null)
        {
            oldNode.Previous.Next = newNode;
        }
        else
        {
            _first = newNode;
        }
        
        oldNode.Previous = newNode;
    }

    public void AddAfter(LinkedNode<T> oldNode, T value)
    {
        LinkedNode<T> newNode = new LinkedNode<T>(value);
        _count++;

        if (oldNode == null)
        {
            throw new ArgumentNullException(nameof(oldNode));
        }

        newNode.Previous = oldNode;
        newNode.Next = oldNode.Next;
        
        if (oldNode.Next != null)
        {
            oldNode.Next.Previous = newNode;
        }
        else
        {
            _last = newNode;
        }
        
        oldNode.Next = newNode;
    }

    public void AddAfter(LinkedNode<T> oldNode, LinkedNode<T> newNode)
    {
        _count++;
        
        if (oldNode == null)
        {
            throw new ArgumentNullException(nameof(oldNode));
        }
        if (newNode == null)
        {
            throw new ArgumentNullException(nameof(newNode));
        }
        
        newNode.Previous = oldNode;
        newNode.Next = oldNode.Next;
        
        if (oldNode.Next != null)
        {
            oldNode.Next.Previous = newNode;
        }
        else
        {
            _last = newNode;
        }
        
        oldNode.Next = newNode;
    }

    public bool Remove(T value)
    {
        for (LinkedNode<T>? node = _first; node != null; node = node.Next)
        {
            if (Equals(node.Value, value))
            {
                if (node.Previous != null)
                {
                    node.Previous.Next = node.Next;
                }
                else
                {
                    _first = node.Next;
                }

                if (node.Next != null)
                {
                    node.Next.Previous = node.Previous;
                }
                else
                {
                    _last = node.Previous;
                }
                
                _count--;
                return true;
            }
        }
        
        return false;
    }

    public void Remove(LinkedNode<T> node)
    {
        if (node == null)
        {
            throw new ArgumentNullException(nameof(node));
        }
        else
        {
            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
            _count--;
        }
    }

    public void RemoveFirst()
    {
        if (_first == null)
        {
            throw new ArgumentNullException(nameof(_first));
        }
        else
        {
            _first.Next.Previous = null;
            _first = _first.Next;
            _count--;
        }
    }

    public void RemoveLast()
    {
        if (_last == null)
        {
            throw new ArgumentNullException(nameof(_last));
        }
        else
        {
            _last.Previous.Next = null;
            _last = _last.Previous;
            _count--;
        }
    }

    public void Clear()
    {
        _first = null;
        _last = null;
        _count = 0;
    }

    public bool Contains(T value)
    {
        for (LinkedNode<T>? node = _first; node != null; node = node.Next)
        {
            if (Equals(node.Value, value))
            {
                return true;
            }
        }
        
        return false;
    }

    public LinkedNode<T>? Find(T value)
    {
        for (LinkedNode<T>? node = _first; node != null; node = node.Next)
        {
            if (Equals(node.Value, value))
            {
                return node;
            }
        }
        
        return null;
    }

    public LinkedNode<T>? FindLast(T value)
    {
        for (LinkedNode<T>? node = _last; node != null; node = node.Previous)
        {
            if (Equals(node.Value, value))
            {
                return node;
            }
        }
        
        return null;
    }
}

public class LinkedNode<T>
{
    public T Value { get; set; }
    public LinkedNode<T>? Next { get; set; }
    public LinkedNode<T>? Previous { get; set; }

    public LinkedNode(T value)
    {
        Value = value;
        Next = null;
        Previous = null;
    }
}