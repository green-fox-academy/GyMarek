using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Sharpie_set
{
    class Program
    {
        static void Main(string[] args)
        {
        //Reuse your Sharpie class
        //Create SharpieSet class
        //it contains a list of Sharpie
        //Add method CountUsable() -> sharpie is usable if it has ink in it
        //Add method RemoveTrash() -> removes all unusable sharpies

            var sharpie = new Sharpie("red", 1, 100);

            sharpie.Use();

            Console.WriteLine("New Sharpie InkAmount: " + sharpie.GetInkAmount());

            Console.ReadKey();
        }
    }
}
