using System;

namespace ex12_Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "pls add the side long of the cuboid";
            string side;
            double sideValue;

            Console.WriteLine(message);

            side = Console.ReadLine();
            sideValue = Convert.ToDouble(side);

            Console.WriteLine("Surface Area: " + sideValue*sideValue*6);
            Console.WriteLine("Volume: " + sideValue*sideValue*sideValue);

            Console.ReadLine();
        }
    }
}
