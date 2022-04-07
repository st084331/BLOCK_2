using System;

namespace ALotOfExceptions;
    public static class InvalidCastException
    {
        public static string ToStringFunction(object value)
        {
            string s = null;
            try
            {
                s = (string) value;
            }
            catch (System.InvalidCastException e)
            {
                Console.WriteLine(e);
            }

            return s;
        }
        
        public static string ToStringFunctionFixed(object value)
        {
            string s = null;
            try
            {
                s = value.ToString();
            }
            catch (System.InvalidCastException e)
            {
                Console.WriteLine(e);
            }

            return s;
        }
        
        public class Parent { }
        public class Child : Parent { }
        public static Child MakeChild()
        {
            Parent p = new Parent();
            try
            {
                Child q = (Child) p;
                return q;
            }
            catch (System.InvalidCastException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        
        public static Child MakeChildFixed()
        {
            Parent p = new Child();
            try
            {
                Child q = (Child) p;
                return q;
            }
            catch (System.InvalidCastException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }