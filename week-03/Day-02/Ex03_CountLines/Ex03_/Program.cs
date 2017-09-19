using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./my-file.txt";
            Console.WriteLine(Counter(path));
            Console.ReadLine();
            // Write a function that takes a filename as string, then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and should not raise any error.
        }

        public static int Counter(string line)
        {              
            try
            {                
                string[] content = File.ReadAllLines(line);
                return content.Length;
            }
            catch (Exception)
            {
                return 0;                
            }          
        }
    }
}
