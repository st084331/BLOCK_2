using System;
using NUnit.Framework;
using static ALotOfExceptions.StackOverflowException;

namespace ALotOfExceptionsTests;

public class StackOverflowExceptionTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(StartRecurFixed(15), 15);
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(StartRecurFixed(0), 0);    }
}