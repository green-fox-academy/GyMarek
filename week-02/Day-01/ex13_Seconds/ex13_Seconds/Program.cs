using System;

namespace ex13_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            Console.WriteLine(24*60*60-currentHours*60*60-currentMinutes*60-currentSeconds);

            Console.ReadLine();

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables
        }
    }
}
