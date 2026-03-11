namespace Lab07;
using System.Collections;
using System.Collections.Generic;

public class DoublyLinkedList<T> : IDoubleEndedCollection<T>, IEnumerable<T>
{
    internal DNode<T>? _head = null;
    private DNode<T>? _tail = null;
    public int Length { get; private set; } = 0;

   public T First 
    { 
        get => _head != null ? _head.Value : throw new InvalidOperationException("List is empty"); 
    }
    public T Last 
    { 
        get => _tail != null ? _tail.Value : throw new InvalidOperationException("List is empty"); 
    }

    public void AddLast(T value)
    { 
        DNode<T> node = new DNode<T>(value, null, null);
        if (Length == 0)
            _head = node;
        else
        {
            node.Previous = _tail;
            _tail.Next = node;
        }  
        _tail = node;
        Length++;
    }
    public void AddFirst(T value)
    {
        DNode<T> node = new DNode<T>(value, null, null);
        if (Length == 0)
            _tail = node;
        else
        {
            node.Next = _head;
            _head.Previous = node;
        }  
        _head = node;
        Length++;
    }
    public void RemoveFirst()
    {
        if(Length == 1)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            DNode<T> next = _head.Next;
            _head.Next = null;
            _head = next;
            next.Previous = null;
        }
        Length--;
    }
    public void RemoveLast()
    {
        if(Length == 1)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            DNode<T> previous = _tail.Previous;
            _tail.Previous = null;
            _tail = previous;
            previous.Next = null;
        }
        Length--;
    }
    public void InsertAfter(DNode<T> node, T value)
    {
        DNode<T> temp = node.Next;
        DNode<T> newNode = new DNode<T>(value, node, temp);
        temp.Previous = newNode;
        node.Next = newNode;
        Length++;
    }
    public void RemoveByValue(T value)
    {
        if(Length == 0) return;
        DNode<T> current = _head;

        while(current.Next != null)
        {
            if(current.Value.Equals(value))
            {
                var previous = current.Previous;
                var next = current.Next;

                previous.Next = next;
                next.Previous = previous;
                
                Length--;
            }
        }
    }
    public void ReverseList()
    {
        if(Length < 2) return;
        DNode<T> current = _head;
        _tail = current;
        while(current.Next != null)
        {
            DNode<T>? tmp = current.Previous;
            current.Previous = current.Next;
            current.Next = tmp;
            current = current.Previous;
        }
        _head = current;
    }
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return new LinkedListEnumerator<T>(_head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new LinkedListEnumerator<T>(_head);
    }
}
