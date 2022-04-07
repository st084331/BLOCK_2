using NUnit.Framework;
using static GenericSort.GenericSort;
namespace GenericSortTests;

public class IntTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(GenericBubbleSort(new int[] {2, 3, 1}), new int[] {1, 2, 3});
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(GenericBubbleSort(new int[] {1}), new int[] {1});
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(GenericBubbleSort(new int[] {}), new int[] {});
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(GenericBubbleSort(new int[] {8, 4, 1, 0, 9, 2, 1, 9}), new int[] {0, 1, 1, 2, 4, 8, 9, 9});
    }
}