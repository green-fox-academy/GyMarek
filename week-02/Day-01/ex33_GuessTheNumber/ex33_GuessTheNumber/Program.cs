using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex33_GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I thought of a number between 1 and 10. Can you figure it out?");         
            Random RandomNo = new Random();
            int ComputerNo = RandomNo.Next(1, 10);
            int UserTip;

            do
            {                
                Console.WriteLine("What's your tip?");
                UserTip = int.Parse(Console.ReadLine());

                if (UserTip > ComputerNo)
                {
                    Console.WriteLine("The stored number is lower.");
                }
                else if (UserTip < ComputerNo)
                {
                    Console.WriteLine("The stored number is higher");
                }
                else
                {
                    Console.WriteLine("You found the number: " + ComputerNo);
                }
            }
            while (UserTip != ComputerNo);
                                                
            Console.ReadKey();

            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8
        }
    }
}
