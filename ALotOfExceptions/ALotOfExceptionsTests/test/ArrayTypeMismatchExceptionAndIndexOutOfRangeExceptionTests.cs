using NUnit.Framework;
using static ALotOfExceptions.ArrayTypeMismatchExceptionAndIndexOutOfRangeException;

namespace ALotOfExceptionsTests;

public class ArrayTypeMismatchExceptionAndIndexOutOfRangeExceptionTests
{
    [Test]
    public void Test1()
    {
        string[] arr = { "Hello", "my", "World" };
        object[] newArr = EdittedCopyArrayFixed(arr, 1, "Pip");
        arr[1] = "Pip";
        Assert.AreEqual(newArr, arr);
    }

    [Test]
    public void Test2()
    {
        string[] arr = {"Hello", "my", "World"};
        Assert.AreEqual(EdittedCopyArrayFixed(arr, 1, 7), arr);
    }

    [Test]
    public void Test3()
    {
        string[] arr = {"Hello", "my", "World"};
        Assert.AreEqual(EdittedCopyArrayFixed(arr, 4, "Pip"), arr);
    }

    [Test]
    public void Test4()
    {
        string[] arr = {"Hello", "my", "World"};
        Assert.AreEqual(EdittedCopyArrayFixed(arr, 9, 7), arr);
    }
}