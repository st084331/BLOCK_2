using NUnit.Framework;
using static ALotOfExceptions.NullReferenceException;

namespace ALotOfExceptionsTests;

public class NullReferenceExceptionTests
{
    [Test]
    public void Test1()
    {
        Assert.AreNotEqual(MakeStackWithOneListFixed("Title1"), null);
    }

    [Test]
    public void Test2()
    {
        Assert.AreNotEqual(MakeStackWithOneListFixed(null), null);
    }

    [Test]
    public void Test3()
    {
        Assert.AreNotEqual(MakeStackWithOneListFixed(""), null);
    }
}