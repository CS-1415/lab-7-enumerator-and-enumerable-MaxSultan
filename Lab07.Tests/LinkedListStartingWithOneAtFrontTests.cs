using System.Security.Cryptography.X509Certificates;

namespace Lab07.Tests;

public class LinkedListStartingWithOneAtFrontTests
{
    private DoublyLinkedList<int> list;

    [SetUp]
    public void Setup()
    {
        list = new DoublyLinkedList<int>();
        list.AddFirst(1);
    }

    [Test]
    public void Test1()
    {
        // Starting state
        Assert.That(list.Length, Is.EqualTo(1));
        Assert.That(list.First, Is.EqualTo(1));
        Assert.That(list.Last, Is.EqualTo(1));
        
        // Add Last
        list.AddLast(2);
        Assert.That(list.Length, Is.EqualTo(2));
        Assert.That(list.First, Is.EqualTo(1));
        Assert.That(list.Last, Is.EqualTo(2));

        list.AddFirst(4);
        Assert.That(list.Length, Is.EqualTo(3));
        Assert.That(list.First, Is.EqualTo(4));
        Assert.That(list.Last, Is.EqualTo(2));

        list.RemoveLast();
        Assert.That(list.Length, Is.EqualTo(2));
        Assert.That(list.First, Is.EqualTo(4));
        Assert.That(list.Last, Is.EqualTo(1));

        list.RemoveFirst();
        Assert.That(list.Length, Is.EqualTo(1));
        Assert.That(list.First, Is.EqualTo(1));
        Assert.That(list.Last, Is.EqualTo(1));
    }
    public void RemoveByValue()
    {
        list.RemoveByValue(1);
        Assert.That(list.Length, Is.EqualTo(0));
        Assert.Throws<InvalidOperationException>(() => _ = list.First);
        Assert.Throws<InvalidOperationException>(() => _ = list.Last);
    }
}