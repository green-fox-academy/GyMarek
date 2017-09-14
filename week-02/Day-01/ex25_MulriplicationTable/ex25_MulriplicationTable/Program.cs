using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex25_MulriplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please give a number:");
            double number = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + " * " + number + " = " + number*i);
            }

            Console.ReadKey();

            // Create a program that asks for a number and prints the multiplication table with that number
            //
            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150
        }
    }
}
