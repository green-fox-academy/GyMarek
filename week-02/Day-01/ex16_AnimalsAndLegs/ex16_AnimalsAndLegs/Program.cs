using System;

namespace ex16_AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many chickens?");

            string chikens = Console.ReadLine();
            double Clegs = Convert.ToDouble(chikens);

            Console.WriteLine("How many pigs");

            string pigs = Console.ReadLine();
            double Plegs = Convert.ToDouble(pigs);

            double sum = 2 * Clegs + 4 * Plegs;

            Console.WriteLine("The number of legs: " + sum);

            Console.ReadLine();


            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
        }
    }
}
