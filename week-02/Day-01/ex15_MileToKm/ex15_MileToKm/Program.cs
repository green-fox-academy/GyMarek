using System;

namespace ex15_MileToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double ChangeNumber = 0.621371;
                      
            Console.WriteLine("How many kms?");

            string km = Console.ReadLine();
            double mile = Convert.ToDouble(km);

            Console.WriteLine(mile*ChangeNumber + " miles");
           
            Console.ReadLine();

            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
        }
    }
}
