using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_StringTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            string input = "Xoxo";
            Console.WriteLine(XchangeY(input));
            Console.ReadLine();
        }
        public static string XchangeY(string input)
        {
            if (input.Length < 1)
                return input;
            else if (input[0] == 'x' || input[0] == 'X')
                return "" + XchangeY(input.Substring(1));
            else
                return input[0] + XchangeY(input.Substring(1));
        }
    }
}
