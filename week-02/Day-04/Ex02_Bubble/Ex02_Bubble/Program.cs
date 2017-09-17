using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Bubble
{
    class Program
    {
        static List<int> Sort(List<int> input, bool desc)
        {
            input.Sort();
            if (desc == true) input.Reverse();
            return input;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please type the elements of list");
            string input = Console.ReadLine();
            List<string> list = input.Split(' ').ToList();

            Sort(list);

            Console.WriteLine(list);

            Console.ReadLine();
            
            //Create a function that takes a list of numbers as parameter
            //Returns a list where the elements are sorted in ascending numerical order
            //Make a second boolean parameter, if it's true sort that list descending
            //Example
            //input[34, 12, 24, 9, 5]
            //output[5, 9, 12, 24, 34]
        }



    }
}
