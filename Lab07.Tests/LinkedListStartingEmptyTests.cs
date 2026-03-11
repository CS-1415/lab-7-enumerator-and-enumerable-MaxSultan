namespace Lab07.Tests;

public class LinkedListStartingEmptyTests
{
    private DoublyLinkedList<int> list;

    [SetUp]
    public void Setup()
    {
        list = new DoublyLinkedList<int>();
    }

    [Test]
    public void Test1()
    {

                // Starting state
        Assert.That(list.Length, Is.EqualTo(0));
        Assert.Throws<InvalidOperationException>(() => _ = list.First);
        Assert.Throws<InvalidOperationException>(() => _ = list.Last);
        
        // Add first
        list.AddFirst(1);
        Assert.That(list.Length, Is.EqualTo(1));
        Assert.That(list.First, Is.EqualTo(1));
        Assert.That(list.Last, Is.EqualTo(1));
        
        // Add Last
        list.AddLast(2);
        Assert.That(list.Length, Is.EqualTo(2));
        Assert.That(list.First, Is.EqualTo(1));
        Assert.That(list.Last, Is.EqualTo(2));
    }
}