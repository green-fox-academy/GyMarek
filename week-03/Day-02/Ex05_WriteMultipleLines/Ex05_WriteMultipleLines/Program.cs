using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex05_WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./my-file.txt";
            string word = "lemon";
            int number = 7;

            MultiplieWriter(path, word, number);

            Console.ReadLine();
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.            
        }
        public static void MultiplieWriter(string path, string word, int number)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < number; i++)
                {
                    writer.WriteLine(word);
                }
            }
        }
    }
}
