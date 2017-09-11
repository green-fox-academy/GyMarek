using System;

namespace ex17_AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Pls write 5 integer:");
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
            string message = Console.ReadLine();
            int number = Int32.Parse(message);
                sum += number;
            }

            Console.WriteLine("SUM: " + sum);
            Console.WriteLine("AVERAGE: " + sum/5.0);

            Console.ReadLine();

            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

        }
    }
}
