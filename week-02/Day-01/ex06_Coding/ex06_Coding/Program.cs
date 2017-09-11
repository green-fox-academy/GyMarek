using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int daily = 6;
            int weeks = 17;
            int weeksday = 5;
            double weeklyhour = 52;

            Console.WriteLine(daily*weeks*weeksday);
            Console.WriteLine((daily*weeks*weeksday)/(weeks*weeklyhour)*100 + "%");

            Console.ReadLine();
        }
    }
}
