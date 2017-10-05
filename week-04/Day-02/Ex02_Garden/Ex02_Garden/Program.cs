using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden myGarden = new Garden();
            Plant flower1 = new Flower("yellow");
            Plant flower2 = new Flower("blue");
            Plant tree1 = new Tree("purple");
            Plant tree2 = new Tree("orange");

            myGarden.ListOfPlants.Add(flower1);
            myGarden.ListOfPlants.Add(flower2);
            myGarden.ListOfPlants.Add(tree1);
            myGarden.ListOfPlants.Add(tree2);
            myGarden.PrintOutGardenState();
            myGarden.Watering(40);
            myGarden.PrintOutGardenState();
            myGarden.Watering(70);
            myGarden.PrintOutGardenState();
            Console.ReadLine();
        }
    }
}
