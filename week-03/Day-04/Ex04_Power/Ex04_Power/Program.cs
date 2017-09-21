using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

            Console.WriteLine("Please give 2 number (bigger than 0) one base than one power.");
            Console.WriteLine("example: 3,2 - where 3 is a base and 2 is a power:");
            string input = Console.ReadLine();
            List<string> list = input.Split(',').ToList();
            int baseNumber = Int32.Parse(list[0]);
            int powerNumber = Int32.Parse(list[1]);

            Console.WriteLine("The result is:"+PowerN(baseNumber, powerNumber));
            Console.ReadLine();
        }
        public static int PowerN(int baseNumber, int powerNumber)
        {
            if (powerNumber==0)
                return 1;
            return baseNumber*PowerN(baseNumber,powerNumber-1);
        }

    }
}
