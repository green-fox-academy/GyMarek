using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary_01
{
    class Program
    {
        static void Main(string[] args)
        {
             string output = "";
             int[] notSoCrypticMessage = { 1, 12, 1, 2, 11, 1, 7, 11, 1, 49, 1, 3, 11, 1, 50, 11 };

    
             var map = new Dictionary<int, string>();

             map.Add(7, "run around and desert you");
             map.Add(50, "tell a lie and hurt you");
             map.Add(49, "make you cry,");
             map.Add(2, "let you down");
             map.Add(12, "give you up,");
             map.Add(1, "Never gonna");
             map.Add(11, "\n");
             map.Add(3, "say goodbye");

             foreach (int key in notSoCrypticMessage)
             {

                if (map.ContainsKey(key))
                {

                    if (key != 11)
                    {
                        output += (map[key] + " ");
                    }
                    else
                    {
                        output += map[key];
                    }

                }

            }

            // if with Ternary operator:
            // output += (map.ContainsKey(key) && key != 11) ? (map[key] + " ") : map[key]; 
           
            
            // Things are a little bit messed up
            // Your job is to decode the notSoCrypticMessage by using the hashmap as a look up table
            // Assemble the fragments into the out variable

            Console.WriteLine(output);
            Console.ReadKey();
                    
        }



    }
}
