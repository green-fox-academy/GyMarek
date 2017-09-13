using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_PrintArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            String one = "first";
            String two = "second";
            String three = "third";
            String four = "fourth";

            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")

            Printer(one);
            Printer(one, two);
            Printer(one, two, three);
            Printer(one, two, three, four);

            Console.ReadLine();
        }

        private static void Printer (params string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + " ");
                
            }
            Console.WriteLine();
        }


    }
}