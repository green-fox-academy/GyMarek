using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("horse", 101, 25);
            Animal animal2 = new Animal("sheep", 33, 50);
            Animal animal3 = new Animal("chicken", 25, 42);
            Animal animal4 = new Animal("cow", 44, 20);

            Farm farm = new Farm();
            farm.Slot = 5;

            farm.AnimalList.Add(animal1);
            farm.AnimalList.Add(animal2);
            farm.AnimalList.Add(animal3);
            farm.AnimalList.Add(animal4);
            
            farm.Breed(farm.AnimalList);
            farm.Slaughter(farm.AnimalList);
            farm.Print(farm.AnimalList);
            Console.ReadLine();
        }
    }
}
