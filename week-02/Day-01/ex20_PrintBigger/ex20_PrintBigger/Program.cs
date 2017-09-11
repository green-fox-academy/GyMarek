using System;

namespace ex20_PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls write an integer");

            string one =Console.ReadLine();
            int a = Int32.Parse(one);

            Console.WriteLine("Pls write another integer");

            string two = Console.ReadLine();
            int b = Int32.Parse(two);

            if (a>b)
            {
                Console.WriteLine("The first number is the bigger one!");
            }
             else if (b>a)
            {
                Console.WriteLine("The second number is the bigger one!");
            }
            else
            {
                Console.WriteLine("Equals! :)");
            }

            Console.ReadLine();
            
        }
    }
}
