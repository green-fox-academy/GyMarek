using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            
            // Check if list contains all of the following elements: 4,8,12,16
            // Print "true" if it contains all, otherwise print "false"
            // Can you do both the different approaches you tried in the previous one?
            // First Solution

            if (list.Contains(4) && list.Contains(8) && list.Contains(12) && list.Contains(16))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            // Second Solution

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 4)
                    for (int j = 0; j < list.Count; j++)
                        if (list[j] == 8)
                            for (int k = 0; k < list.Count; k++)
                                if (list[k] == 12)
                                    for (int l = 0; l < list.Count; l++)
                                        if (list[l] == 16)
                                        {
                                            Console.WriteLine("true");
                                            Console.ReadLine();
                                        }
            }
            Console.WriteLine("false");


            Console.ReadLine();
        }
    }
}