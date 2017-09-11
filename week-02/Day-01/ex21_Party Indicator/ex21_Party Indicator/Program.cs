using System;

namespace ex21_Party_Indicator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Girls Number");

            string girls = Console.ReadLine();
            int g = Int32.Parse(girls);

            Console.WriteLine("Boys Number");

            string boys = Console.ReadLine();
            int b = Int32.Parse(boys);

            if (g == 0)
            {
                Console.WriteLine("Sausage party");
            }

            else
            {
                if (g + b < 20)
                {
                    Console.WriteLine("Average party...");
                }
                else if (g != b)
                {
                    Console.WriteLine("Quite cool party!");
                }
                else
                {
                    Console.WriteLine("The party is exellent!");
                }


            }
        Console.ReadLine();
            }

    }
}