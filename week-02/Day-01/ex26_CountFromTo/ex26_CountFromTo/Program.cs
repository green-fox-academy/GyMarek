using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex26_CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please give a number:");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please give another number:");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num2 <= num1)
                {
                Console.WriteLine("The second number should be bigger");
                }
            else
                {
                for (int i = 0; i < (num2-num1); i++)
                    {
                    Console.WriteLine(num1+i);
                    }
                }
        
            Console.ReadLine();


            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
        }
    }
}
