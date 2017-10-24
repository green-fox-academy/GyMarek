using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_FrequencyAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string freqChar = "Time is an illusion. Lunchtime doubly so.";

            //var freqCharLinq = from chars in freqChar.ToLower()
            //                   where chars != ' '
            //                   group chars by chars into uniqueChar
            //                   select new
            //                   {
            //                       uniqueChar.Key,
            //                       Count = (from chars in uniqueChar select chars).Count()
            //                   };

            //foreach (var character in freqCharLinq)
            //{
            //    Console.WriteLine(character);
            //}

            //var freqCharWithLambda = freqChar.ToLower().Where(x => x != ' ').GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            //foreach (var character2 in freqCharWithLambda)
            //{
            //    Console.WriteLine(character2);
            //}


            
            Dictionary<char, int> freqCharOld = new Dictionary<char, int>();
            freqChar = freqChar.Replace(" ", String.Empty).ToLower();

            for (int i = 0; i < freqChar.Length; i++)
            {
                if (freqCharOld.ContainsKey(freqChar[i]))
                {
                    freqCharOld[freqChar[i]]++;
                }
                else
                {
                    freqCharOld.Add(freqChar[i], 1);
                }
            }

            foreach (var item in freqCharOld)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
