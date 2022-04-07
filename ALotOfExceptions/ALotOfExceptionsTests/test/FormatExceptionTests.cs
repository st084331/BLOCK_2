using NUnit.Framework;
using static ALotOfExceptions.FormatException;

namespace ALotOfExceptionsTests;

public class FormatExceptionTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(StringToInt("10"), 10);
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(StringToInt("10.2"), 0);
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(StringToInt("bruh"), 0);
    }
    [Test]
    public void Test4()
    {
        Assert.AreEqual(StringToInt("131252"), 131252);
    }
}