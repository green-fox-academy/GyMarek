using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Dice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dice myDice = new Dice();

            myDice.Roll();

            for (int i = 0; i < myDice.GetCurrent().Length; i++)
            {
                while (myDice.GetCurrent(i) != 6)
                {
                    myDice.Reroll(i);
                    Console.WriteLine(myDice.GetCurrent(i));
                }
            }

            foreach (var dice in myDice.GetCurrent())
            {
                Console.Write("{0} ", dice);
            }

            Console.ReadLine();
        }
    }
}
