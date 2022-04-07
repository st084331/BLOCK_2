
using System;
using System.IO;
namespace ALotOfExceptions;
    public static class FileNotFoundException
    {
        public static bool FileOpener(string path)
        {
            try
            {
                File.Open(path, FileMode.Open);
                return true;
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        
        public static bool FileOpenerFixed(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Open(path, FileMode.Open);
                    return true;
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
    }