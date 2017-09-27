using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ex05_Fibonacci;

namespace TestFibonacci
{
    public class TestFibo
    {
        [Test]
        public void TestFibonacciWithGreaterThanZero()
        {
            int input = 4;

            double output = 2;

            Assert.AreEqual(output, Fibonacci.GetNthFibonacciWithRecursion(input));
        }

        [Test]
        public void TestFibonacciWithLessEqualThanZero()
        {
            int input = -10;

            double output = 0;

            Assert.AreEqual(output, Fibonacci.GetNthFibonacciWithRecursion(input));
        }        
    }
}
