using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_BunniesOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively
            //(without loops or multiplication).

            Console.WriteLine(BunnyEarCounter(7)); 
            Console.ReadLine();
        }
        public static int BunnyEarCounter(int n)
        {
            if (n == 0)
                return 0;
            return 2 + BunnyEarCounter(n - 1);
        }
    }
}
