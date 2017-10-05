using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Garden
{
    class Garden
    {
        Plant plant = new Plant();
        public List<Plant> ListOfPlants = new List<Plant>();
        //public List<Plant> ListOfPlants { get; set; }

        public void Watering(double wateringAmount)
        {
            double waterGet = wateringAmount / ListOfPlants.Count;
            for (int i = 0; i < ListOfPlants.Count; i++)
            {
                if (ListOfPlants[i].wateringTreshold > ListOfPlants[i].currentWaterAmount)
                {
                    ListOfPlants[i].Water(waterGet);
                }
            }
            Console.WriteLine("Watering with " + wateringAmount);
        }

        public void PrintOutGardenState()
        {
            for (int i = 0; i < ListOfPlants.Count; i++)
            {
                if (ListOfPlants[i].wateringTreshold > ListOfPlants[i].currentWaterAmount)
                {
                    Console.WriteLine("The {0} {1} needs water", ListOfPlants[i].color, ListOfPlants[i].type);
                }
                else
                {
                    Console.WriteLine("The {0} {1} doesn't need water", ListOfPlants[i].color, ListOfPlants[i].type);
                }
            }
        }

    }
}
