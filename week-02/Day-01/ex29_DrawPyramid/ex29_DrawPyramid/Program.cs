using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex29_DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was


            Console.WriteLine("Please give the base of the triangle:");
            int pyramid = Int32.Parse(Console.ReadLine());
                     
            for (int i = 0; i <= pyramid; i++)
            {
                for (int j = 0; j < pyramid - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
