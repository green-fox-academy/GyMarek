using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex34_ParametricAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me how many numbers do yo want to test:");
            int UserNumber = Int32.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < UserNumber; i++)
            {
                Console.WriteLine("Please give me another number:");
                int number = Int32.Parse(Console.ReadLine());
                sum += number;            
            }

            int average = sum / UserNumber;

            Console.WriteLine();
            Console.WriteLine("Sum: " + sum + " Average: " + average);
            Console.ReadKey();

            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.ReadLine();
        }
    }
}
