using NUnit.Framework;
using static GenericSort.GenericSort;
namespace GenericSortTests;

public class DoubleTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(GenericBubbleSort(new double[] {2.2D, 3.1D, 1.21D}), new double[] {1.21D, 2.2D, 3.1D});
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(GenericBubbleSort(new double[] {1.0D}), new double[] {1.0D});
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(GenericBubbleSort(new double[] {}), new double[] {});
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(GenericBubbleSort(new double[] {0.99999999999D, 1D, 0.99999998D}), new double[] {0.99999998D, 0.99999999999D, 1D});
    }
    
    [Test]
    public void Test5()
    {
        Assert.AreEqual(GenericBubbleSort(new double[] {0.0000000000000000001, 0, 0.000000001}), new double[] {0, 0.0000000000000000001, 0.000000001});
    }
}