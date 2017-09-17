using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex32_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give the diagonal lines:");
            int diagonal = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < diagonal; i++)
            {
                Console.Write("%");
            }
            Console.WriteLine();
            
            for (int i = 0; i < diagonal - 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("%");
                }                    
                for (int j = 0; j < diagonal - 2; j++)
                {
                    if (j == i)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = 0; j < 1; j++)
                    Console.Write("%");

                Console.WriteLine();
            }

            for (int i = 0; i < diagonal; i++)
            {
                Console.Write("%");
            }            

            Console.ReadKey();

            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was
        }
    }
}
