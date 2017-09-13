using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // "What I cannot create, I do not understand"? do <--> cannot

            string temp = list[2]; 
            list[2] = list[5]; 
            list[5] = temp;
            
            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code

            // Also, print the sentence to the output with spaces in between.

            Console.WriteLine(String.Join(" ", list));
            Console.ReadKey();
        }
    }
}
