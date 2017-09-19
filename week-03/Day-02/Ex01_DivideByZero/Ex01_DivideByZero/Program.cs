using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0

            Console.WriteLine("Pls give a number");
            int InputNumber = Int32.Parse(Console.ReadLine());
            Divide(InputNumber);
            Console.ReadLine();
        }

        public static int Divide (int num)
        {      
            try  
            {
                int result = 10 / num;               
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {            
                Console.WriteLine("Fail");
            }            
            return num;
        }
    }
}
