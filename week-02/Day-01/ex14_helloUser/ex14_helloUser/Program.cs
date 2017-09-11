using System;

namespace ex14_helloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!");
           
            Console.ReadLine();

            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
        }
    }
}
