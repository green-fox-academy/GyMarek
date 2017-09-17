using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] JaggedColors = new string[][]
            {
                new string[] {"lime", "forest green", "olive", "pale green", "spring green"},
                new string[] {"orange red", "red", "tomato" },
                new string[] {"orchid", "violet", "pink", "hot pink" }
            };

            for (int i = 0; i < JaggedColors.Length; i++)
            {
                Console.Write("Colors({0}): ", i + 1);

                for (int j = 0; j < JaggedColors[i].Length; j++)
                {
                    Console.Write(JaggedColors[i][j] + "\t");
                }
                Console.WriteLine();
            }
            
            // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`
            Console.ReadLine();
        }
    }
}
