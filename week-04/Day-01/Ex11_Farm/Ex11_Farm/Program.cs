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
            Animal cat = new Animal("cat ", 40, 10);            
            Animal dog = new Animal("dog ", 30, 20);
            Animal cow = new Animal("cow", 20, 30);
            Animal chicken = new Animal("chicken", 10, 40);

            Farm farm = new Farm();
            farm.slots = 5;

            farm.AnimalList.Add(cat);
            farm.AnimalList.Add(dog);
            farm.AnimalList.Add(cow);
            farm.AnimalList.Add(chicken);

            farm.Breed(farm.AnimalList);
            farm.Slaughter(farm.AnimalList);
            farm.Print(farm.AnimalList);
            Console.ReadKey();
        }
    }
}
