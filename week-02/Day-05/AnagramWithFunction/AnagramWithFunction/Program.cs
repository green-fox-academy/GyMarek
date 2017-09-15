using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramWithFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a word:");
            string first = Console.ReadLine();
            first = first.Replace(" ", "");


            Console.WriteLine("Please write another word t" +
                "o check it is an anagram or no:");
            string second = Console.ReadLine();
            second = second.Replace(" ", "");


            Console.WriteLine(IsAnagram(first, second));

            Console.ReadLine();
        }

        static bool IsAnagram(string first, string second)
        {
            char[] firstChars = first.ToCharArray();
            Array.Sort(firstChars);
            char[] secondChars = second.ToCharArray();
            Array.Sort(secondChars);

            bool anagram = true;            

            if (firstChars.Length != secondChars.Length)
            {
                anagram = false;
            }
            else
            {
                for (int i = 0; i < firstChars.Length; i++)
                {
                    if (firstChars[i] != secondChars[i])
                    {
                        anagram = false;
                    }
                }
            }
            return anagram;
        }
    }
}

                 
    