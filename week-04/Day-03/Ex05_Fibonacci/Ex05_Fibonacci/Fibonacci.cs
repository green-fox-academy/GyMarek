using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Fibonacci
{
    public class Fibonacci
    {
        public static double GetNthFibonacciWithRecursion(int n)
        {
            double nthFibonacci = 0;
            if (n == 2)
            {
                nthFibonacci = 1;
            }
            if (n <= 2)
            {
                return nthFibonacci;
            }
            return GetNthFibonacciWithRecursion(n - 1) + GetNthFibonacciWithRecursion(n - 2);
        }
    }
}
