using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLetter
{
    public class AppendLetter
    {
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };

            for (int i = 0; i < far.Count; i++)
            {
                far[i] = far.ElementAt(i) + "a";
                // .ElementAt(0) will throw an exception,
                //if the index is greater than or equal to the number of elements in the list.
            }

            // Add "a" to every string in the far list.

            foreach (string a in far)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}