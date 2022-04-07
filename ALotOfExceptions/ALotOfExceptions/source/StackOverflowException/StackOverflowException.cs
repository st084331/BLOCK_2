using System;
namespace ALotOfExceptions;
    public static class StackOverflowException
    {
        private static int Rec(int limit, int count)
        {
            if (count == 104783)
            {
                throw new System.StackOverflowException();
            }
            int variable = 1;
            if (count < limit || limit == -1)
            {
                return variable + Rec(limit, count + 1);
            }
            else
            {
                return 0;
            }
        }
        
        public static int StartRecur(int limit)
        {
            int res = 0;
            try
            {
                res = Rec(limit, 0);
            }
            catch (System.StackOverflowException e)
            {
                Console.WriteLine(e);
            }

            return res;
        }
        
        public static int StartRecurFixed(int limit)
        {
            int res = 0;
            if (limit > Int16.MaxValue * 3 || limit == -1)
            {
                limit = Int16.MaxValue * 3;
            }
            try
            {
                res = Rec(limit, 0);
            }
            catch (System.StackOverflowException e)
            {
                Console.WriteLine(e);
            }

            return res;
        }
    }