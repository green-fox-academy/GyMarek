using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex07_Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathfrom = @"./duplicated-chars.txt";
            string pathto = @"./chars.txt.txt";

            Decrypts(pathfrom,pathto);          

            Console.ReadLine();

            // Create a method that decrypts the duplicated-chars.txt 
        }


        static void Decrypts(string pathfrom, string pathto)
        {
            string[] content = File.ReadAllLines(pathfrom);

            for (int i = 0; i < content.Length; i++)
            {
                var text = new List<char>(content[i]);

                for (int j = 0; j < text.Count - 1; j++) //not final, find a solution to ignore this step
                {
                    text.RemoveAt(j);
                }
                content[i] = string.Join("", text.ToArray());
            }
            File.WriteAllLines(pathto, content);
            Console.WriteLine("Copy was successful");
        }
    }
}