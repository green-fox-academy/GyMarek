using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharpie = new Sharpie("red", 1, 100);

            sharpie.Use();

            Console.WriteLine("New Sharpie InkAmount: " + sharpie.GetInkAmount());

            Console.ReadKey();
        }
    }
}
