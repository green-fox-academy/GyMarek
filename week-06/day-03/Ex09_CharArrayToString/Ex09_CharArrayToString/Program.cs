using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_CharArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] test = new char[] { 'd', 'g', 'i', 'o', 'f', 'a', };
            
            string stringFromArrayQuery = String.Concat(
                                           from character in test
                                           select character);

            Console.WriteLine(stringFromArrayQuery);

            string stringFromArrayLambda = String.Concat(test.Select(character => character));

            Console.WriteLine(stringFromArrayLambda);

            Console.ReadLine();
        }
    }
}
