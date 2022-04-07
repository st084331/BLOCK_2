using NUnit.Framework;
using static ALotOfExceptions.InvalidCastException;

namespace ALotOfExceptionsTests;

public class InvalidCastExceptionTests
{
    [Test]
    public void TestToString1()
    {
        Assert.AreEqual(ToStringFunctionFixed(10), "10");
    }

    [Test]
    public void TestToString2()
    {
        Assert.AreEqual(ToStringFunctionFixed(10.12), "10.12");    }

    [Test]
    public void TestToString3()
    {
        Assert.AreEqual(ToStringFunctionFixed(false), "False");    }

    [Test]
    public void TestToString4()
    {
        Assert.AreEqual(ToStringFunctionFixed('c'), "c");    }
    
    [Test]
    public void TestChild()
    {
        Assert.AreNotEqual(MakeChildFixed(), null);
    }
}