using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Anagram
{
    public class Anagram
    {
        public static bool IsAnagram(string first, string second)
        {
        if (first != null && second != null)
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
        return false;       
        }
    }
}
