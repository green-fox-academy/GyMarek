using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Fibonacci
{
    class Program
    {
        static Dictionary<int, double> FibonacciCache = new Dictionary<int, double>
        {
            { 1,0},
            { 2,1},
        };

        static void Main(string[] args)
        {
            // The fibonacci sequence is a famous bit of mathematics, and it happens to
            // have a recursive definition. The first two values in the sequence are
            // 0 and 1 (essentially 2 base cases). Each subsequent value is the sum of the
            // previous two values, so the whole sequence is: 0, 1, 1, 2, 3, 5, 8, 13, 21
            // and so on. Define a recursive fibonacci(n) method that returns the nth
            // fibonacci number, with n=0 representing the start of the sequence.

            Console.WriteLine(GetNthFibonacciWithFor(5));
            Console.WriteLine(GetNthFibonacciWithWhile(6));
            Console.WriteLine(GetNthFibonacciWithList(7));
            Console.WriteLine(GetNthFibonacciWithRecursion(8));
            Console.WriteLine(GetNthFibonacciWithRecursionMemoization(9));
            Console.ReadLine();
        }

        private static double GetNthFibonacciWithRecursionMemoization(int n)
        {         
            if (FibonacciCache.ContainsKey(n))
            {
                return FibonacciCache[n];
            }

            GetNthFibonacci(n - 1);
            GetNthFibonacci(n - 2);

            return FibonacciCache[n - 1] + FibonacciCache[n - 2];
        }

        private static void GetNthFibonacci(int n)
        {
            if (FibonacciCache.ContainsKey(n))
            {
                return;
            }
            double nthFibonacci = GetNthFibonacciWithRecursionMemoization(n);
            FibonacciCache.Add(n, nthFibonacci);
        }

        private static double GetNthFibonacciWithRecursion(int n)
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

        private static double GetNthFibonacciWithList(int n)
        {
            List<double> fibonaccis = new List<double>();

            int i = 1;
            while (fibonaccis.Count < n)
            {
                fibonaccis.Add(GetNthFibonacciWithFor(i));
                i++;
            }
            return fibonaccis[n - 1];
        }
        
        private static double GetNthFibonacciWithWhile(int n)
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
            int ithFibonacci = 3;
            double prevPrev = 0;
            double prev = 1;
            while (ithFibonacci <= n)
            {
                nthFibonacci = prevPrev + prev;
                prevPrev = prev;
                prev = nthFibonacci;
                ithFibonacci++;
            }
            return nthFibonacci;
        }

        private static double GetNthFibonacciWithFor(int n)
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

            double prevPrev = 0;
            double prev = 1;
            for (int i = 1; i < n-1; i++)
            {
                nthFibonacci = prevPrev + prev;
                prevPrev = prev;
                prev = nthFibonacci;
            }
            return nthFibonacci;
        }
    }
}
