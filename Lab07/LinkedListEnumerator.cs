namespace Lab07;
using System.Collections;
using System.Collections.Generic;

public class LinkedListEnumerator<T> : IDisposable, IEnumerator<T>
{
    public T Current { get; private set; } = default!;
    object? IEnumerator.Current => (object)Current;

    private DNode<T>? _firstNode;
    private DNode<T>? _currentNode;

    public LinkedListEnumerator(DNode<T>? head){
        _firstNode = head;
        _currentNode = null;
    }
    
    public bool MoveNext()
    {
        if (_currentNode == null)
        {
            if (_firstNode == null) return false;
            // the enumerator needs an internal reference to the node AND the value
            _currentNode = _firstNode;
            Current = _currentNode.Value;
            return true;
        }
        if (_currentNode.Next != null)
        {
            _currentNode = _currentNode.Next;
            Current = _currentNode.Value;
            return true;
        } 
        return false;
    }

    public void Reset()
    {
        _currentNode = null;
        Current = default!;
    }
    
    public void Dispose(){}
}