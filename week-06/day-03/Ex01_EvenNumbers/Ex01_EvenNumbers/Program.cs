using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> evenNumberQuery =
                from even in n
                where even %2 == 0
                select even;

            IEnumerable<int> evenNumberWithLambda = n.Where(y => y % 2 == 0);

            foreach (var number in evenNumberQuery)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            foreach (var lambdaNumber in evenNumberWithLambda)
            {
                Console.Write(lambdaNumber + " ");
            }

            Console.ReadKey();
        }
    }
}
