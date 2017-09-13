using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list. 
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines

            list[list.IndexOf(2)] = "Croissant";
            list[list.IndexOf(false)] = "Ice cream";

            //list[1] = "Croissant";  
            //list[3] = "Ice Cream";

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
