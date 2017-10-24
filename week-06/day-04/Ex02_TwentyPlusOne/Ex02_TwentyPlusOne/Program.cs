using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_TwentyPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var test = Enum.GetValues(typeof(Rank));

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
