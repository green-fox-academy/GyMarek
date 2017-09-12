using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_PrintAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] af = {4, 5, 6, 7};

            // - Create an array variable named `af`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `af`

            foreach(int i in af)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
    }
}
