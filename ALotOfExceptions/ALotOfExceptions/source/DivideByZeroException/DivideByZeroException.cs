using System;

namespace ALotOfExceptions;

public static class DivideByZeroException
{
    public static int Divider(int a, int b)
    {
        try
        {
            return a / b;
        }
        catch (System.DivideByZeroException e)
        {
            Console.WriteLine(e);
            return default;
        }
    }

    public static int DividerFixed(int a, int b)
    {
        try
        {
            if (b != 0) return a / b;
            else return default;
        }
        catch (System.DivideByZeroException e)
        {
            Console.WriteLine(e);
            return default;
        }
    }
}