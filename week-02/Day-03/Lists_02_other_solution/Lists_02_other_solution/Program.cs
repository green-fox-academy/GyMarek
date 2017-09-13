using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = girls.Join(boys, s => girls.IndexOf(s), i => boys.IndexOf(i), (s, i) => new { sv = s, iv = i }).ToList();

            foreach (var x in order)
            {
                Console.WriteLine("{0}, {1}", x.sv, x.iv);
            }
            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.ReadKey();
        }
    }
}
