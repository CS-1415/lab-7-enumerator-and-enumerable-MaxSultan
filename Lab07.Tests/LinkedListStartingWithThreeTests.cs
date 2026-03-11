namespace Lab07.Tests;

public class LinkedListStartingWithThreeTests
{
    private DoublyLinkedList<int> list;

    [SetUp]
    public void Setup()
    {
        list = new DoublyLinkedList<int>();
        list.AddFirst(1);
        list.AddLast(2);
        list.AddLast(3);
    }

    [Test]
    public void ReverseList()
    {
        // Starting state
        Assert.That(list.Length, Is.EqualTo(3));
        Assert.That(list.First, Is.EqualTo(1));
        Assert.That(list.Last, Is.EqualTo(3));

        list.ReverseList();
        Assert.That(list.Length, Is.EqualTo(3));
        Assert.That(list.First, Is.EqualTo(3));
        Assert.That(list.Last, Is.EqualTo(1));
    }

    public void RemoveByValue()
    {
        list.RemoveByValue(1);
        Assert.That(list.Length, Is.EqualTo(2));
        Assert.That(list.First, Is.EqualTo(2));
        Assert.That(list.Last, Is.EqualTo(3));
    }
}