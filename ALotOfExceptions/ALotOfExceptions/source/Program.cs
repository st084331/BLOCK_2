using ALotOfExceptions;
using DivideByZeroException = ALotOfExceptions.DivideByZeroException;
using FileNotFoundException = ALotOfExceptions.FileNotFoundException;
using InvalidCastException = ALotOfExceptions.InvalidCastException;
using NullReferenceException = ALotOfExceptions.NullReferenceException;
using OutOfMemoryException = ALotOfExceptions.OutOfMemoryException;
using StackOverflowException = ALotOfExceptions.StackOverflowException;
using FormatException = ALotOfExceptions.FormatException;

string[] arr = { "Welcome", "to", "CSharp" };

/* BROKEN PART
Console.WriteLine(OutOfMemoryException.ConnectStrings("Hi", "My Name Is", 9));
Console.WriteLine(NullReferenceException.MakeStackWithOneList("default"));
Console.WriteLine(InvalidCastException.MakeChild());
string[] arr = { "Welcome", "to", "CSharp" };
ArrayTypeMismatchExceptionAndIndexOutOfRangeException.EdittedCopyArray(arr, 5, 43);
Console.WriteLine(DivideByZeroException.Divider(1,0));
Console.WriteLine(StackOverflowException.StartRecur(Int16.MaxValue*20));
FileNotFoundException.FileOpener("baka");
Console.WriteLine(FormatException.StringToInt("10.2"));
*/

/* FIXED PART
Console.WriteLine(OutOfMemoryException.ConnectStringsFixed("Hi", "My Name Is"));
Console.WriteLine(NullReferenceException.MakeStackWithOneListFixed("default"));
Console.WriteLine(InvalidCastException.MakeChildFixed());
string[] arr = { "Welcome", "to", "CSharp" };
ArrayTypeMismatchExceptionAndIndexOutOfRangeException.EdittedCopyArrayFixed(arr, 5, 43);
Console.WriteLine(DivideByZeroException.DividerFixed(1,0));
Console.WriteLine(StackOverflowException.StartRecurFixed(Int16.MaxValue*20));
FileNotFoundException.FileOpenerFixed("baka");
Console.WriteLine(FormatException.StringToIntFixed("10.2"));
*/

