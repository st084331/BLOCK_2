using System;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using static GenericSort.GenericSort;
namespace GenericSortTests;

public class ObjectTest
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(GenericBubbleSort(new object[] {"true", "rolling down", "bumer", "pi"}, CompareStr), new object[] {"pi", "true", "bumer", "rolling down"});
    }

    [Test]
    public void Test2()
    {
        TestClass c0 = new TestClass();
        Assert.AreEqual(GenericBubbleSort(new object[] {c0}, (o, o1) => 0), new object[] {c0});
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(GenericBubbleSort(new object[] {}, (o, o1) => 0), new object[] {});
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(GenericBubbleSort(new object[] {1, 5 ,9, 3}, ReverseIntCompare), new object[] {9, 5, 3, 1});
    }

    private class TestClass
    {
    }

    private int ReverseIntCompare(object I1, object I2)
    {
        int i1 = Convert.ToInt32(I1);
        int i2 = Convert.ToInt32(I2);
        if (i1 < i2)
        {
            return 1;
        }else if (i1 == i2)
        {
            return 0;
        }else
        {
            return -1;
        }
    }
    
    private int CompareStr(object S1, object S2)
    {
        string s1 = S1.ToString();
        string s2 = S2.ToString();
        if (s1.Length < s2.Length)
        {
            return -1;
        }else if (s1.Length == s2.Length)
        {
            return 0;
        }else
        {
            return 1;
        }
    }
}