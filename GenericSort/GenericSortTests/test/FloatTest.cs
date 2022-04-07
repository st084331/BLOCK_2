using NUnit.Framework;
using static GenericSort.GenericSort;
namespace GenericSortTests;

public class FloatTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(GenericBubbleSort(new float[] {2.2F, 3.1F, 1.21F}), new float[] {1.21F, 2.2F, 3.1F});
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(GenericBubbleSort(new float[] {1.0F}), new float[] {1.0F});
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(GenericBubbleSort(new float[] {}), new float[] {});
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(GenericBubbleSort(new float[] {0.99999999999F, 1, 0.99999998F}), new float[] {0.99999998F, 0.99999999999F, 1});
    }
    
    [Test]
    public void Test5()
    {
        Assert.AreEqual(GenericBubbleSort(new float[] {0.0000000000000000001F, 0, 0.000000001F}), new float[] {0, 0.0000000000000000001F, 0.000000001F});
    }
    
    [Test]
    public void Test6()
    {
        Assert.AreEqual(GenericBubbleSort(new float[] {1.000000000000000000000002F, 1.000000000000000000000001F, 1.000000000000000000000003F}), new float[] {1.000000000000000000000001F, 1.000000000000000000000002F, 1.000000000000000000000003F});
    }
}