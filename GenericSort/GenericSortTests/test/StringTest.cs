using NUnit.Framework;
using static GenericSort.GenericSort;
namespace GenericSortTests;

public class StringTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(GenericBubbleSort(new string[] {"Hi", "My Name Is", "Danil"}), new string[] {"Danil", "Hi", "My Name Is"});
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(GenericBubbleSort(new string[] {"One"}), new string[] {"One"});
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(GenericBubbleSort(new string[] {}), new string[] {});
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(GenericBubbleSort(new string[] {"hi", "Hi", "This", "this"}), new string[] {"hi", "Hi", "this", "This"});
    }
    
}