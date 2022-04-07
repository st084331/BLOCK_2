using NUnit.Framework;
using static GenericSort.GenericSort;
namespace GenericSortTests;

public class CharTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(GenericBubbleSort(new char[] {'c', '2', 'o', 'b'}), new char[] {'2', 'b', 'c', 'o'});
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(GenericBubbleSort(new char[] {'c'}), new char[] {'c'});
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(GenericBubbleSort(new char[] {}), new char[] {});
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(GenericBubbleSort(new char[] {'2', '1', '3'}), new char[] {'1', '2', '3'});
    }
    
}