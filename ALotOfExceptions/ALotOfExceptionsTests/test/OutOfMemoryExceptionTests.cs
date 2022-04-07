using NUnit.Framework;
using static ALotOfExceptions.OutOfMemoryException;

namespace ALotOfExceptionsTests;

public class OutOfMemoryExceptionTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(ConnectStringsFixed("", "Hi").ToString(), "Hi");
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(ConnectStringsFixed("Hi","").ToString(), "Hi");
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(ConnectStringsFixed("","").ToString(), "");
    }
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(ConnectStringsFixed("Hi","Hi").ToString(), "HiHi");
    }
}