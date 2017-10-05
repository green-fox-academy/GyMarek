using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Farm
{
    class Farm
    {
        //it has list of Animals
        //it has slots which defines the number of free places for animals
        //breed() -> creates a new animal if there's place for it
        //slaughter() -> removes the least hungry animal

        public int slot;    
        public List<Animal> animalList = new List<Animal>();

        public List<Animal> AnimalList
        {
            get
            {
                return animalList;
            }
            set
            {
                animalList = value;
            }
        }

        public int Slot
        {
            get
            {
                return slot;
            }
            set
            {
                slot = value;
            }
        }

        public List<Animal> Breed(List<Animal> animalList)
        {
            if (slot > animalList.Count)
            {
                Animal newAnimal = new Animal();
                animalList.Add(newAnimal);
            }
            return animalList;
        }

        public List<Animal> Slaughter(List<Animal> animalList)
        {
            int hunger = 100;
            int lessHungryIndex = 0;
            for (int i = 0; i < animalList.Count; i++)
            {
                if (animalList[i].Hunger < hunger)
                {
                    hunger = animalList[i].Hunger;
                    lessHungryIndex = i;
                }
            }
            animalList.RemoveAt(lessHungryIndex);
            return animalList;
        }

        public void Print(List<Animal> animalList)
        {
            foreach (var animal in animalList)
            {
                Console.WriteLine("The animal type is: " + animal.NameOfAnimal + " , thirst value: " + animal.Thirst + ", hunger value: " + animal.Hunger);
            }
        }
    }
}
