using NUnit.Framework;
using static ALotOfExceptions.FileNotFoundException;

namespace ALotOfExceptionsTests;

public class FileNotFoundExceptionTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(FileOpenerFixed("10"), false);
    }

    [Test]
    public void Test2()
    {
        Assert.AreEqual(FileOpenerFixed("/Users/akabynda/RiderProjects/ALotOfExceptions/ALotOfExceptionsTests/test/test.txt"), true);
    }

    [Test]
    public void Test3()
    {
        Assert.AreEqual(FileOpenerFixed(".txt"), false);
    }

    [Test]
    public void Test4()
    {
        Assert.AreEqual(FileOpenerFixed("filefilefile"), false);
    }
}