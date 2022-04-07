using System.Linq;
using DLL;
using NUnit.Framework;

namespace Tests;

public class ExtendsTests
{
    Extends<int> extend = new Extends<int>(); 
    
    [Test]
    public void AnyTest()
    {
        int[] arr = new[] {1, 2, 3};
        Assert.AreEqual(extend.Any(arr), true);
    }
    
    [Test]
    public void AnyTestForEmpty()
    {
        int[] arr = new int[] { };
        Assert.AreEqual(extend.Any(arr), false);
    }
    
    [Test]
    public void AnyFuncTest()
    {
        int[] arr = new[] {1, 2, 3};
        Assert.AreEqual(extend.Any(arr, i => i%2 == 1), true);
    }
    
    [Test]
    public void CountTest()
    {
        int[] arr = new[] {1, 2, 3};
        Assert.AreEqual(extend.Count(arr), 3);
    }
    
    [Test]
    public void ElementAtTest()
    {
        int[] arr = new[] {1, 2, 3};
        Assert.AreEqual(extend.ElementAt(arr, 2), 3);
    }
    
    [Test]
    public void ElementAtOrDefaultTest()
    {
        int[] arr = new[] {1, 2, 3};
        Assert.Multiple(() =>
        {
            Assert.AreEqual(extend.ElementAtOrDefault(arr, 5), 0);
            Assert.AreEqual(extend.ElementAtOrDefault(arr, 2), 3);
        });
    }
    
    [Test]
    public void FirstTest()
    {
        int[] arr = new[] {1, 2, 3};
        Assert.AreEqual(extend.First(arr), 1);
    }
    
    [Test]
    public void LastTest()
    {
        int[] arr = new[] {1, 2, 3};
        Assert.AreEqual(extend.Last(arr), 3);
    }
    
    [Test]
    public void FirstOrDefaultTest()
    {
        int[] arr1 = new[] {1, 2, 3};
        int[] arr2 = new int[] { };
        Assert.Multiple(() =>
        {
            Assert.AreEqual(extend.FirstOrDefault(arr2), 0);
            Assert.AreEqual(extend.FirstOrDefault(arr1), 1);
        });
    }
    
    [Test]
    public void LastOrDefaultTest()
    {
        int[] arr1 = new[] {1, 2, 3};
        int[] arr2 = new int[] { };
        Assert.Multiple(() =>
        {
            Assert.AreEqual(extend.LastOrDefault(arr2), 0);
            Assert.AreEqual(extend.LastOrDefault(arr1), 3);
        });
    }

    [Test]
    public void MaxTest()
    {
        int[] arr = new[] {1, 3, 2, 1};
        Assert.AreEqual(extend.Max(arr, (i1, i2) => i1 < i2), 3);
    }
    
    [Test]
    public void MinTest()
    {
        int[] arr = new[] {5, 3, 2, 5};
        Assert.AreEqual(extend.Min(arr, (i1, i2) => i1 < i2), 2);
    }
    
    [Test]
    public void ReverseTest()
    {
        int[] arr = new[] {1,2,3};
        int[] rev_arr = extend.Reverse(arr);
        Assert.AreEqual(rev_arr, new int[] {3, 2, 1});
    }
    
    [Test]
    public void AnyTestForList()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.AreEqual(extend.Any(testList), true);
    }
    
    [Test]
    public void AnyTestForEmptyForList()
    {
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>();
        Assert.AreEqual(extend.Any(testList), false);
    }
    
    [Test]
    public void AnyFuncTestForList()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.AreEqual(extend.Any(testList, i => i%2 == 1), true);
    }
    
    [Test]
    public void CountTestForList()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.AreEqual(extend.Count(testList), 3);
    }
    
    [Test]
    public void ElementAtTestForList()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.AreEqual(extend.ElementAt(testList, 2), 3);
    }
    
    [Test]
    public void ElementAtOrDefaultTestForList()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.Multiple(() =>
        {
            Assert.AreEqual(extend.ElementAtOrDefault(testList, 5), 0);
            Assert.AreEqual(extend.ElementAtOrDefault(testList, 2), 3);
        });
    }
    
    [Test]
    public void FirstTestForList()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.AreEqual(extend.First(testList), 1);
    }
    
    [Test]
    public void LastTestForList()
    {
        int[] arr = new[] {1, 2, 3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.AreEqual(extend.Last(testList), 3);
    }
    
    [Test]
    public void FirstOrDefaultTestForList()
    {
        int[] arr1 = new[] {1, 2, 3};
        DoublyLinkedList<int> testList1 = new DoublyLinkedList<int>(arr1);
        DoublyLinkedList<int> testList2 = new DoublyLinkedList<int>();
        Assert.Multiple(() =>
        {
            Assert.AreEqual(extend.FirstOrDefault(testList2), 0);
            Assert.AreEqual(extend.FirstOrDefault(testList1), 1);
        });
    }
    
    [Test]
    public void LastOrDefaultTestForList()
    {
        int[] arr1 = new[] {1, 2, 3};
        DoublyLinkedList<int> testList1 = new DoublyLinkedList<int>(arr1);
        DoublyLinkedList<int> testList2 = new DoublyLinkedList<int>();
        Assert.Multiple(() =>
        {
            Assert.AreEqual(extend.LastOrDefault(testList2), 0);
            Assert.AreEqual(extend.LastOrDefault(testList1), 3);
        });
    }

    [Test]
    public void MaxTestForList()
    {
        int[] arr = new[] {1, 3, 2, 1};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.AreEqual(extend.Max(testList, (i1, i2) => i1 < i2), 3);
    }
    
    [Test]
    public void MinTestForList()
    {
        int[] arr = new[] {5, 3, 2, 5};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        Assert.AreEqual(extend.Min(testList, (i1, i2) => i1 < i2), 2);
    }
    
    [Test]
    public void ReverseTestForList()
    {
        int[] arr = new[] {1,2,3};
        DoublyLinkedList<int> testList = new DoublyLinkedList<int>(arr);
        int[] rev_arr = extend.Reverse(testList);
        Assert.AreEqual(rev_arr, new int[] {3, 2, 1});
    }
}