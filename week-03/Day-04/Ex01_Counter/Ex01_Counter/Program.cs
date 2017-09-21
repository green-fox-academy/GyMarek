using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.

            countDown(15);
            Console.ReadLine();
        }
        public static void countDown(int n)
        {
            if (n < 0)
                return ;
            Console.WriteLine(n);
            countDown(n - 1);
        }
    }
}
