using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] abc = new string[] { "first", "second", "third" };

            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

            string temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            foreach (string number in abc)
            {
                Console.WriteLine("{0} ", number);
            }

            Console.ReadLine();
        }
    }
}
