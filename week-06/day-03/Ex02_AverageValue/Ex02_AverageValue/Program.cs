using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_AverageValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> oddNumberQuery =
                from odd in n
                where Math.Abs(odd % 2) == 1
                select odd;

            double oddNumberQueryAverage = oddNumberQuery.Average();
            Console.WriteLine(oddNumberQueryAverage);
            Console.WriteLine();

            IEnumerable<int> oddNumberWithLambda = n.Where(y => Math.Abs(y % 2) == 1);

            double oddNumberWithLambdaAverage = oddNumberWithLambda.Average();
            Console.WriteLine(oddNumberWithLambdaAverage);
            Console.ReadKey();
        }
    }
}
