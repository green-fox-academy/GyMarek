using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_CountLetters
{
    public class CountLetters
    {
        public Dictionary<char, int> LetterCounter(string input)
        {
            Dictionary<char, int> output = new Dictionary<char, int>();

            if (input != null)
            {
                char[] fromString = input.Replace(" ","").ToCharArray();

                foreach (var character in fromString)
                {                   
                    if (!output.ContainsKey(character))
                    {
                        output.Add(character, 1);
                    }
                    else
                    {
                        output[character]++;
                    }
                }            
            }
            return output;            
        }
    }
}