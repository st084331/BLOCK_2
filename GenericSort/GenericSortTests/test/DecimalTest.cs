using NUnit.Framework;
using static GenericSort.GenericSort;
namespace GenericSortTests;

public class DecimalTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(GenericBubbleSort(new decimal[] {2.23M, 3, 1.1M}), new decimal[] {1.1M, 2.23M, 3});
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(GenericBubbleSort(new decimal[] {1}), new decimal[] {1});
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(GenericBubbleSort(new decimal[] {}), new decimal[] {});
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(GenericBubbleSort(new decimal[] {4, 24.7M, 0.3M, 1}), new decimal[] {0.3M, 1, 4, 24.7M});
    }
}