using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./my-file.txt";
          
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("Gyula Nemes");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my - file.txt");
            } 
            
            Console.ReadLine();
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"
        }        
    }
}
