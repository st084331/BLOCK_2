using NUnit.Framework;
using static GenericSort.GenericSort;
namespace GenericSortTests;

public class BoolTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(GenericBubbleSort(new bool[] {true, true, false, true}), new bool[] {false, true, true, true});
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(GenericBubbleSort(new bool[] {true}), new bool[] {true});
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(GenericBubbleSort(new bool[] {}), new bool[] {});
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(GenericBubbleSort(new bool[] {false, true, true, false, true}), new bool[] {false, false, true, true, true});
    }
}