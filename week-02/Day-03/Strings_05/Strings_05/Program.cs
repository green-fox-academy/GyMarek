using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            reversed = Reversal(reversed);

            Console.WriteLine(reversed);

            Console.ReadKey();
        }

        private static string Reversal (string name)
        {
            string reversedTemp = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversedTemp += name[i];
            }
            return reversedTemp;
        }

    }
}
