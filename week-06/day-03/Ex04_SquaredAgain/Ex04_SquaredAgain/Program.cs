using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_SquaredAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 3, 9, 2, 8, 6, 5 }; 

            IEnumerable<int> NumberSquareQuery =
                from number in n
                where number*number > 20
                select number;

            foreach (var number in NumberSquareQuery)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            IEnumerable<int> numberSquareWithLambda = n.Where(y => y*y > 20);

            foreach (var number in numberSquareWithLambda)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
