using System;

namespace ex18_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls write an integer:");
            
            string message = Console.ReadLine();
            int number = Int32.Parse(message);

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is an even");
            }
            else 
            {
                Console.WriteLine("The number is an odd");
            }
                        
            Console.ReadLine();


            // Write a program that reads a number form the standard input,
            // Than prints "Odd" if the number is odd, or "Even" it it is even.
        }
    }
}
