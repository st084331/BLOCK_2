namespace ALotOfExceptions;

public static class FormatException
{
    public static int StringToInt(string s)
    {
        try
        {
            return Convert.ToInt32(s);
        }
        catch (System.FormatException e)
        {
            Console.WriteLine(e);
            return default;
        }
    }
    
    public static int StringToIntFixed(string s)
    {
        try
        {
            int res;
            bool isNumber = int.TryParse(s, out res);
            return res;
        }
        catch (System.FormatException e)
        {
            Console.WriteLine(e);
            return default;
        }
    }
}