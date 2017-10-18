using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string upperChar = "Time is an illusion. Lunchtime doubly so.";

            var upperCharLinq = from chars in upperChar
                                where Char.IsUpper(chars)
                                select chars;

            foreach (var upper in upperCharLinq)
            {
                Console.Write(upper + ",");
            }

            Console.WriteLine();

            var upperCharLambda = upperChar.Where(x => Char.IsUpper(x));

            foreach (var upper2 in upperCharLambda)
            {
                Console.Write(upper2 + ",");
            }

            Console.ReadKey();
        }
    }
}
