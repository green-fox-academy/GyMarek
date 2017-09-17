using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex31_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give the square lines:");
            int line = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i < line; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("%%%%%");
                }
                if (i == line - 1)
                {
                    Console.WriteLine("%%%%%");
                }
                else
                {
                    Console.WriteLine("%   %");
                }
            }

            Console.ReadKey();

            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was
        }
    }
}
