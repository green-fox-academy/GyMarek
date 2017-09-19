using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex06_CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathfrom = @"./my-file.txt";
            string pathto = @"./my-newfile.txt";

            ReadCopyWrite(pathfrom, pathto);

            Console.ReadLine();

            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
        }
        static bool ReadCopyWrite(string pathfrom, string pathto)
        {            
            try
            {
                string[] content = File.ReadAllLines(pathfrom);
                File.WriteAllLines(pathto, content);
                Console.WriteLine("Copy was successful");
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}
