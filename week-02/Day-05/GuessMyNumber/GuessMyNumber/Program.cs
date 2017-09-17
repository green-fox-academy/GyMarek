using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my number! Please give me the starting range number.");
            int range1 = int.Parse(Console.ReadLine());
            Console.WriteLine("And what should be the end of the range?");
            int range2 = int.Parse(Console.ReadLine());
            
            Random r = new Random();
            int rInt = r.Next(range1, range2);

            Console.WriteLine("Please give me how many lives do you want:");
            int lives = int.Parse(Console.ReadLine());

            Console.WriteLine("I've the number between " +range1+ " and " +range2+ " You have " +lives+ " lives." );

            int no = 0;
            
            while (no != rInt && lives != 0)
            {
                Console.WriteLine("Enter your number");
                no = Int32.Parse(Console.ReadLine());
                if (no > rInt)
                {
                    lives--;
                    Console.WriteLine("Too high! You have " + lives + " lives left");
                }
                else if (no < rInt)
                {
                    lives--;
                    Console.WriteLine("Too low! You have " + lives + " lives left");
                }
            }
            if (no == rInt)
            {
                Console.WriteLine("Congratulations.You won!");
            }
            else if (lives == 0)
            {
                Console.WriteLine("Game Over! :(");
            }
            Console.ReadKey();
        }
    }
}
