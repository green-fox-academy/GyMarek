using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls write an integer");

            string one = Console.ReadLine();
            int a = Int32.Parse(one);

            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter
            Console.WriteLine(Sum(a));
            Console.ReadLine();
        }

        public static int Sum (int num)
        {
            int b = num;

            for (int i=0; i<b; i++)
            {
                num += i;
            }
            return num;
        }
    }
}