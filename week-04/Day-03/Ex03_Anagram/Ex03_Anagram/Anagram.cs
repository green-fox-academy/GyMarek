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
            bool IsAnagram = false;

            first = first.Replace(" ", String.Empty).ToLower();
            second = second.Replace(" ", String.Empty).ToLower();

            char[] firstChars = first.ToCharArray();
            Array.Sort(firstChars);            
            char[] secondChars = second.ToCharArray();
            Array.Sort(secondChars);

            if (firstChars.Length == secondChars.Length &&
                firstChars.SequenceEqual(secondChars))
            {
                IsAnagram = true;
                return IsAnagram;
            }
            return IsAnagram;
        }
    }
}
