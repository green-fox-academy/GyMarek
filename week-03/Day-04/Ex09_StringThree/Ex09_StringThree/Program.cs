using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_StringThree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".

            string input = "Xoxoxoxoxoxo";
            Console.WriteLine(Separate(input));
            Console.ReadLine();
        }
        public static string Separate(string input)
        {
            if (input.Length < 1)
                return input;
            else
                return input[0] + " " + Separate(input.Substring(1));
        }
    }
}
