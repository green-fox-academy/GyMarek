using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_FoxClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfFoxes = new List<Fox>
                {
                    new Fox ("Torpapa", "Pallida", "green"),
                    new Fox ("Hami", "Alpaga", "red"),
                    new Fox ("Torpilla", "Static", "blue"),
                    new Fox ("UgyiFogyi", "Rabbit", "yellow"),
                    new Fox ("Torperos", "Oracle", "black"),
                };

            var greenfoxesQ = from fox in listOfFoxes
                           where fox.color == "green"
                           select fox;          

            foreach (var green in greenfoxesQ)
            {
                Console.WriteLine(green.ToString());
            }

            var greenfoxesL = listOfFoxes.Where(x => x.color == "green").Select(x => x);

            foreach (var green2 in greenfoxesL)
            {
                Console.WriteLine(green2.ToString());
            }

            var greenPallidaQ = from fox in listOfFoxes
                               where fox.color == "green" && fox.type == "Pallida"
                               select fox;

            foreach (var greenP in greenPallidaQ)
            {
                Console.WriteLine(greenP.ToString());
            }

            var greenPallidaL = listOfFoxes.Where(x => x.color == "green" && x.type == "Pallida").Select(x => x);

            foreach (var greenP2 in greenPallidaL)
            {
                Console.WriteLine(greenP2.ToString());
            }

            Console.ReadKey();
        }
    }
}
