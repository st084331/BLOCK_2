using System;
using System.Collections.Concurrent;
using System.Text;

namespace ALotOfExceptions;
    public static class OutOfMemoryException
    {
        
        // Если Len < First.Length+Second.Length, то будет System.OutOfMemoryException
        public static StringBuilder ConnectStrings(string First, string Second, int Len)
        {
            StringBuilder sBuilder = new StringBuilder(Len, Len);
            try
            {
                sBuilder.Append(First);
                sBuilder.Insert(First.Length, Second, 1);
            }
            catch (System.OutOfMemoryException e)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(e);
            }
            return sBuilder;
        }
        
        // Устраняем проблему
        public static StringBuilder ConnectStringsFixed(string First, string Second)
        {
            if (First.Length + Second.Length == 0) return new StringBuilder();
            StringBuilder sBuilder = new StringBuilder(First.Length+Second.Length, First.Length+Second.Length);
            try
            {
                sBuilder.Append(First);
                sBuilder.Insert(First.Length, Second, 1);
            }
            catch (System.OutOfMemoryException e)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(e);
            }
            return sBuilder;
        }
    }
