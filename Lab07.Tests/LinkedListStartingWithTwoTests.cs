namespace Lab07.Tests;

public class LinkedListStartingWithTwoTests
{
    private DoublyLinkedList<int> list;

    [SetUp]
    public void Setup()
    {
        list = new DoublyLinkedList<int>();
        list.AddFirst(1);
        list.AddLast(2);
    }

    [Test]
    public void Test1()
    {
        // Starting state
        Assert.That(list.Length, Is.EqualTo(2));
        Assert.That(list.First, Is.EqualTo(1));
        Assert.That(list.Last, Is.EqualTo(2));

        list.RemoveFirst();
        Assert.That(list.Length, Is.EqualTo(1));
        Assert.That(list.First, Is.EqualTo(2));
        Assert.That(list.Last, Is.EqualTo(2));

        // Empty List
        list.RemoveLast();
        Assert.That(list.Length, Is.EqualTo(0));
        Assert.Throws<InvalidOperationException>(() => _ = list.First);
        Assert.Throws<InvalidOperationException>(() => _ = list.Last);
    }
}