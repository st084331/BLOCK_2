using NUnit.Framework;
using static GenericSort.GenericSort;
namespace GenericSortTests;

public class ByteTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(GenericBubbleSort(new byte[] {2, 3, 1}), new byte[] {1, 2, 3});
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(GenericBubbleSort(new byte[] {1}), new byte[] {1});
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(GenericBubbleSort(new byte[] {}), new byte[] {});
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(GenericBubbleSort(new byte[] {4, 247, 3, 1}), new byte[] {1, 3, 4, 247});
    }
}