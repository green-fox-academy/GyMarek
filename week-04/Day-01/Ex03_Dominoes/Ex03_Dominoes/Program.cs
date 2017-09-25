using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Dominoes
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            CheckList(dominoes);
            Console.ReadLine();

            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

        }
        
        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }

        public static void CheckList(List<Domino> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[0].GetValues()[1] == input[j].GetValues()[0])
                    {
                        Console.Write("[" + input[j].GetValues()[0] + " , " + input[j].GetValues()[1] + "]" + " , ");
                        input[0].GetValues()[0] = input[j].GetValues()[0];
                        input[0].GetValues()[1] = input[j].GetValues()[1];
                    }
                }
            }
        }
    }
}

