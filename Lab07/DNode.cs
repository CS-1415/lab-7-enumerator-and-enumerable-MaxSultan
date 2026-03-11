namespace Lab07;

public class DNode<T> 
{
    public T Value { get; set; }
    public DNode<T>? Previous { get; set; }
    public DNode<T>? Next { get; set; }
    public DNode(T value, DNode<T>? previous, DNode<T>? next)
    {
        Value=value;
        Previous=previous;
        Next=next;
    }
}

