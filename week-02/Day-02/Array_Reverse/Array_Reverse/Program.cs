using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aj = new int [] {3, 4, 5, 6, 7};

            foreach (int i in aj)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            Array.Reverse(aj);

            foreach (int i in aj)
            {
                Console.Write("{0} ", i);
            }

            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
            Console.ReadLine();
        }
    }
}
