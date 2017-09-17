using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Unique
{
    class Program
    {
        static List<int> Unique(List<int> input)
        {
            input.Sort();
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[i] == input[j])
                    {
                        input.Remove(input[i]);
                    }
                }
            }
            input.Sort();
            return input;
        }


        static void Main(string[] args)
        {
            List<int> input = new List<int> { 1, 11, 34, 11, 52, 61, 1, 34 };

            Unique(input);

            foreach (int i in input)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadLine();
            
            //Create a function that takes a list of numbers as a parameter
            //Returns a list of numbers where every number in the list occurs only once
            //Example
            //input: [1, 11, 34, 11, 52, 61, 1, 34]
            //output: [1, 11, 34, 52, 61]
        }        
    }
}
