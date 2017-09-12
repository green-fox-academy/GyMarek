using System;

namespace Function_Greeter
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";

            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`

            Console.WriteLine(Greet(al));
            Console.ReadLine();
        }

        public static string Greet (string name)
        {
            return name = "Greetings dear, " + name;
        }
    }
}


