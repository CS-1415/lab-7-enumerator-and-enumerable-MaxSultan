using Lab07;

void Main()
{
    DoublyLinkedList<int> list = new DoublyLinkedList<int>();
    list.AddLast(100);
    list.AddFirst(55);

    foreach(var value in list){ Console.Write($"{value}, ");};
}

Main();