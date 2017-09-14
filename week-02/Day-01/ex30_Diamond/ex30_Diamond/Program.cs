using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex30_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            Console.WriteLine("Please give the base of the diamond:");
            int diamond = Int32.Parse(Console.ReadLine());
            
            for (int i = 1; i < diamond / 2 + 1; i++)
            {
                for (int j = diamond / 2 + 1 - i; j > 0; j--)
                {
                    Console.Write(" ");                    
                }
                Console.Write("*");

                for (int k = i + 1; k < 2 * i; k++)
                {
                    Console.Write("**");                    
                }
                Console.WriteLine();
            }
            if (diamond % 2 == 1)
            {
                for (int i = 1; i < diamond + 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = diamond / 2; i > 0; i--)
            {
                for (int j = diamond / 2 + 1 - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                for (int k = i + 1; k < 2 * i; k++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
            Console.ReadLine();                        
        }
    }
}
