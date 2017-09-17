using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = new string[] { "kuty", "macsk", "kacs", "rók", "halacsk" };           

            // - Create an array variable named `nimals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
            
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] += "a";                
            }

            foreach (string anima in animals)
            {
                Console.WriteLine(anima);
            }

            Console.ReadKey();
        }
    }
}
