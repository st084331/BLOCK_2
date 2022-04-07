using System;

namespace ALotOfExceptions;
    public static class ArrayTypeMismatchExceptionAndIndexOutOfRangeException
    {
        public static object[] EdittedCopyArrayFixed(object[] arr, int pos, object newElem)
        {
            object[] res = new object[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = arr[i];
            }

            try
            {
                if (newElem.GetType() == res[0].GetType() && pos >= 0 && pos < res.Length) res[pos] = newElem;
            }
            catch (System.ArrayTypeMismatchException e)
            {
                Console.WriteLine(e);
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            return res;
        }
        
        public static object[] EdittedCopyArray(object[] arr, int pos, object newElem)
        {
            object[] res = new object[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = arr[i];
            }
            try
            {
                res[pos] = newElem;
            }
            catch (System.ArrayTypeMismatchException e)
            {
                Console.WriteLine(e);
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            return res;
        }
    }