using System;
using System.Linq;
using DLL;
using NUnit.Framework;

namespace Tests;

public class DLL_Tests
{
    [Test]
    public void GetCountTest()
    {
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>();
        Assert.AreEqual(0, testList.getCount());
    }
    
    [Test]
    public void GetFirstTest()
    {
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>();
        Assert.AreEqual(null, testList.getFirst());
    }

    [Test]
    public void GetLastTest()
    {
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>();
        Assert.AreEqual(null, testList.getLast());
    }

    [Test]
    public void ArrayToDllTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.Multiple(() =>
        {
            Assert.AreEqual(testList.getFirst().getData(), 1);
            Assert.AreEqual(testList.getLast().getData(), 3);
            Assert.AreEqual(testList.getFirst().getNext().getData(), 2);
            Assert.AreEqual(testList.getLast().getPrev().getData(), 2);
            Assert.AreEqual(testList.getFirst().getNext().getPrev().getData(), 1);
            Assert.AreEqual(testList.getLast().getPrev().getNext().getData(), 3);
        });
    }

    [Test]
    public void GetNodeTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.Multiple(() =>
        {
            Assert.AreEqual(1, testList.getNode(0).getData());
            Assert.AreEqual(2, testList.getNode(1).getData());
            Assert.AreEqual(3, testList.getNode(2).getData());
        });
    }

    [Test]
    public void AddLastByDataTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        testList.AddLast(5);
        Assert.AreEqual(5, testList.getLast().getData());
    }
    
    [Test]
    public void AddLastByNodeTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        testList.AddLast(new DoublyLinkedNode<int>(5));
        Assert.AreEqual(5, testList.getLast().getData());
    }
    
    [Test]
    public void AddFirstByDataTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        testList.AddFirst(5);
        Assert.AreEqual(5, testList.getFirst().getData());
    }
    
    [Test]
    public void AddFirstByNodeTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        testList.AddFirst(new DoublyLinkedNode<int>(5));
        Assert.AreEqual(5, testList.getFirst().getData());
    }
    
    [Test]
    public void AddAfterByDataTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        testList.AddAfter(testList.getFirst(), 5);
        Assert.AreEqual(5, testList.getFirst().getNext().getData());
    }
    
    [Test]
    public void AddAfterByNodeTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        testList.AddAfter(testList.getFirst(), new DoublyLinkedNode<int>(5));
        Assert.AreEqual(5, testList.getFirst().getNext().getData());
    }
    
    [Test]
    public void AddBeforeByDataTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        testList.AddBefore(testList.getLast(), 5);
        Assert.AreEqual(5, testList.getLast().getPrev().getData());
    }
    
    [Test]
    public void AddBeforeByNodeTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        testList.AddBefore(testList.getLast(), new DoublyLinkedNode<int>(5));
        Assert.AreEqual(5, testList.getLast().getPrev().getData());
    }
    
    [Test]
    public void ClearTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        testList.Clear();
        Assert.Multiple(() =>
        {
            Assert.AreEqual(testList.getFirst(), null);
            Assert.AreEqual(testList.getLast(), null);
        });
    }
    
    [Test]
    public void ContainsTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.Multiple(() =>
        {
            Assert.AreEqual(testList.Containts(2), true);
            Assert.AreEqual(testList.Containts(4), false);
        });
    }
    
    [Test]
    public void FindTest()
    {
        int[] arr = new[] {1, 2, 2 ,3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.Multiple(() =>
        {
            Assert.AreEqual(testList.Find(2), testList.getFirst().getNext());
            Assert.AreEqual(testList.Find(4), null);
        });
    }
    
    [Test]
    public void FindLastTest()
    {
        int[] arr = new[] {1, 2, 2 ,3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.Multiple(() =>
        {
            Assert.AreEqual(testList.FindLast(2), testList.getLast().getPrev());
            Assert.AreEqual(testList.FindLast(4), null);
        });
    }
    
    [Test]
    public void EqualsTest()
    {
        int[] arr = new[] {1, 2, 2 ,3};
        DoublyLinkedList<int> testList1 = new DoublyLinkedList<int>(arr);
        DoublyLinkedList<int> testList2 = new DoublyLinkedList<int>();
        Assert.Multiple(() =>
        {
            Assert.AreEqual(testList1.Equals(testList1), true);
            Assert.AreEqual(testList1.Equals(testList2), false);
            Assert.AreEqual(testList1.Equals(arr), false);
        });
    }

    [Test]
    public void RemoveNodeByDataTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList1 = new DoublyLinkedList<int>(arr);
        testList1.RemoveNode(2);
        Assert.AreEqual(testList1.getFirst().getNext().getData(), 3);
    }
    
    [Test]
    public void RemoveNodeByNodeTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList1 = new DoublyLinkedList<int>(arr);
        testList1.RemoveNode(testList1.getFirst().getNext());
        Assert.AreEqual(testList1.getFirst().getNext().getData(), 3);
    }
    
    [Test]
    public void RemoveFirstTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList1 = new DoublyLinkedList<int>(arr);
        testList1.RemoveFirst();
        Assert.AreEqual(testList1.getFirst().getData(), 2);
    }
    
    [Test]
    public void RemoveLastTest()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList1 = new DoublyLinkedList<int>(arr);
        testList1.RemoveLast();
        Assert.AreEqual(testList1.getLast().getData(), 2);
    }
    
    [Test]
    public void RemoveFirstTestForOneElement()
    {
        int[] arr = new[] {1};
        DoublyLinkedList<int> testList1 = new DoublyLinkedList<int>(arr);
        testList1.RemoveFirst();
        Assert.AreEqual(testList1.getFirst(), null);
    }
    
    [Test]
    public void RemoveLastTestForOneElement()
    {
        int[] arr = new[] {1};
        DoublyLinkedList<int> testList1 = new DoublyLinkedList<int>(arr);
        testList1.RemoveLast();
        Assert.AreEqual(testList1.getLast(), null);
    }
    
}