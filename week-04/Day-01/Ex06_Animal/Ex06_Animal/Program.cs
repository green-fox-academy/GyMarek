using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal("cat ", 50, 50);
            cat.Drink();
            Console.WriteLine("cat " + cat.GetThirst());

            Animal dog = new Animal("dog ", 50, 50);
            dog.Eat();
            Console.WriteLine("dog " + dog.GetHunger());

            Animal monkey = new Animal("monkey", 50, 50);
            monkey.Play();
            Console.WriteLine("monkey" + monkey.GetThirst());
            Console.WriteLine("monkey" + monkey.GetHunger());

            Console.ReadKey();
        }
    }
}
