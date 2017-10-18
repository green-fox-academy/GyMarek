using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyNumbersLinq = 
                                from number in n                               
                                group number by number into uniqNumber
                                select new
                                {
                                    uniqNumber.Key,
                                    Count = (from number in uniqNumber select number).Count()
                                };

            foreach (var num in frequencyNumbersLinq)
            {
                Console.WriteLine(num);
            }

            var frequencyNumbersWithLambda = n.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (var num2 in frequencyNumbersWithLambda)
            {
                Console.WriteLine(num2);
            }

            Console.ReadKey();
        }
    }
}