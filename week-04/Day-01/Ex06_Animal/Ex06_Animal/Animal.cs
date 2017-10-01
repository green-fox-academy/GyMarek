using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Animal
{
    public class Animal
    {
        public string NameOfAnimal;                            
        public int Hunger = 50;                               
        public int Thirst = 50;

        public Animal(string NameOfAnimal, int Hunger, int Thirst)
        {
            this.NameOfAnimal = NameOfAnimal;
            this.Hunger = Hunger;
            this.Thirst = Thirst;
        }

        public void Eat()                                       
        {
            Hunger--;
        }

        public void Drink()                                    
        {
            Thirst--;
        }

        public void Play()                                      
        {
            Hunger++;
            Thirst++;
        }

        public int GetHunger()                                  
        {
            return Hunger;
        }

        public int GetThirst()                                  
        {
            return Thirst;
        }
    }
}
