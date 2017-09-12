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

            // - Create a function called `factorio`
            //   that returns it's input's factorial
            Console.WriteLine(Factorio(a));
            Console.ReadLine();
        }

        public static int Factorio (int num)
        {
            int b = num;

            for (int i = 1; i < b; i++)
            {
                num *= i;
            }
            return num;
        }
    }
}