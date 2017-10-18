using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Squared
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> positiveNumberSquareQuery =
                from positiveNumber in n
                where positiveNumber >= 0
                select positiveNumber*positiveNumber;

            foreach (var number in positiveNumberSquareQuery)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            IEnumerable<int> positiveNumberWithLambda = n.Where(y => y >= 0).Select(y => y*y);

            foreach (var number in positiveNumberWithLambda)
            {
                Console.Write(number+ " ");
            }

            Console.ReadKey();
        }
    }
}
