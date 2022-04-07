using NUnit.Framework;
using static ALotOfExceptions.DivideByZeroException;

namespace ALotOfExceptionsTests;

public class DivideByZeroExceptionTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(Divider(1,0), 0);
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(Divider(6,2), 3);
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(Divider(12,5), 2);
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(Divider(3,5), 0);
    }
}