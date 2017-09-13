using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_08

{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            Console.WriteLine("Please type in the expression: (for example: + 3 3)" );
            string input = Console.ReadLine();
            List<string> list = input.Split(' ').ToList();
            long a = Int64.Parse(list[1]);
            long b = Int64.Parse(list[2]);

            if (list[0] == "+")
            {
                Add(a, b);
            }

            if (list[0] == "-")
            {
                Subtract(a, b);
            }

            if (list[0] == "*")
            {
                Multiply(a, b);
            }
            if (list[0] == "/")
            {
                Divide(a, b);
            }
            if (list[0] == "%")
            {
                Percentage(a, b);                       
            }

            Console.ReadLine();
        }

        public static void Add(long a, long b)
        {
            Console.WriteLine(a + b);
        }
       
        public static void Subtract(long a, long b)
        {
            Console.WriteLine(a - b);
        }

        public static void Multiply(long a, long b)
        {
            Console.WriteLine(a * b);
        }

        public static void Divide(long a, long b)
        {
            Console.WriteLine(a / b);
        }

        public static void Percentage(long a, long b)
        {
            Console.WriteLine((a / b) * 100);
        }
    }
}