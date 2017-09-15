using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a word:");
            string first = Console.ReadLine();
            first = first.Replace(" ", "");
            char[] firstChars = first.ToCharArray();
            Array.Sort(firstChars);

            Console.WriteLine("Please write another word t" +
                "o check it is an anagram or no:");
            string second = Console.ReadLine();
            second = second.Replace(" ", "");
            char[] secondChars = second.ToCharArray();
            Array.Sort(secondChars);

            if (firstChars.Length != secondChars.Length)
            {
                Console.WriteLine("Not anagrams :(");
            }
            else
            {
                for (int i = 0; i < firstChars.Length; i++)
                {
                    if (firstChars[i] != secondChars[i])
                    {
                        Console.WriteLine("Not anagrams :(");
                    }                    
                }
            }

            Console.WriteLine("The second one is an anagram :)");
            
            Console.ReadLine();
        }
    }
}
