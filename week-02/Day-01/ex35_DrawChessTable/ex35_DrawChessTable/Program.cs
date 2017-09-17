using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex35_DrawChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is your chess table :)");

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("% % % % ");
                }
                else
                {
                    Console.WriteLine(" % % % %");
                }
            }

            Console.ReadLine();

            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
        }
    }
}
