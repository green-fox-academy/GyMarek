using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Dice
{
    public class Dice
    {
        //    You have a Dice class which has 6 dice
        //    You can roll all of them with Roll()
        //    Check the current rolled numbers with GetCurrent()
        //    You can reroll with Reroll()
        //    Your task is to get where all dice is a 6

        static Random RandomValue = new Random();
        static int[] Dices = new int[6];

        public int[] Roll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
            return Dices;
        }

        public int[] GetCurrent()
        {
            return Dices;
        }

        public int GetCurrent(int i)
        {
            return Dices[i];
        }

        public void Reroll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
        }

        public void Reroll(int k)
        {
            Dices[k] = new Random().Next(1, 7);
        }
    }
}
