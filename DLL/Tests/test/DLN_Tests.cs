using DLL;
using NUnit.Framework;
namespace Tests;

public class DLN_Tests
{
    [Test]
    public void GetDataTest()
    {
        DoublyLinkedNode<int> testNode = new DoublyLinkedNode<int>(5);
        Assert.AreEqual(testNode.getData(), 5);
    }
    
    [Test]
    public void GetNextTest()
    {
        DoublyLinkedNode<int> testNode = new DoublyLinkedNode<int>(5);
        Assert.AreEqual(testNode.getNext(), null);
    }
    
    [Test]
    public void GetPrevTest()
    {
        DoublyLinkedNode<int> testNode = new DoublyLinkedNode<int>(5);
        Assert.AreEqual(testNode.getPrev(), null);
    }
    
    [Test]
    public void SetNextTest()
    {
        DoublyLinkedNode<int> testNode1 = new DoublyLinkedNode<int>(5);
        DoublyLinkedNode<int> testNode2 = new DoublyLinkedNode<int>(7);
        testNode1.setNext(testNode2);
        Assert.AreEqual(testNode1.getNext(), testNode2);
    }
    
    [Test]
    public void SetPrevTest()
    {
        DoublyLinkedNode<int> testNode1 = new DoublyLinkedNode<int>(5);
        DoublyLinkedNode<int> testNode2 = new DoublyLinkedNode<int>(7);
        testNode1.setPrev(testNode2);
        Assert.AreEqual(testNode1.getPrev(), testNode2);
    }
    
    [Test]
    public void SetDataTest()
    {
        DoublyLinkedNode<int> testNode = new DoublyLinkedNode<int>(5);
        testNode.setData(6);
        Assert.AreEqual(testNode.getData(), 6);
    }
}