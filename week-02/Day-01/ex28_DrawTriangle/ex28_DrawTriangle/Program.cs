using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex28_DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("Please give the base of the triangle:");
            int triangle = Int32.Parse(Console.ReadLine());
            string star = "*";

            for (int i = 0; i < triangle ; i++)
            {
                Console.WriteLine(star);
                star += "*";
            }

            Console.ReadLine();
        }
    }
}
