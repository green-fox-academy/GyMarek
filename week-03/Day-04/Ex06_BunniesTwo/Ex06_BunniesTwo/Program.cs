using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_BunniesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies 
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say 
            // have 3 ears, because they each have a raised foot. Recursively return the 
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

            Console.WriteLine(BunnyEarCounter(5));
            Console.ReadLine();
        }
        public static int BunnyEarCounter(int n)
        {
            if (n == 0)
                return 0;
            else if (n % 2 == 0)
                return 3 + BunnyEarCounter(n - 1);           
            return 2 + BunnyEarCounter(n - 1);
        }
    }
}
