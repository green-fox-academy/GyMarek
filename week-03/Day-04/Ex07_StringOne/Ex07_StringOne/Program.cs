using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_StringOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.

            string input = "xoxo";      
            Console.WriteLine(XchangeY(input));
            Console.ReadLine();
        }
        public static string XchangeY(string input)
        {
            if (input.Length < 1)
                return input;
            else if (input[0] == 'x')
                return 'y' + XchangeY(input.Substring(1));
            else
                return input[0] + XchangeY(input.Substring(1));
        }
    }
}
