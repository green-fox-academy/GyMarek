using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Garden
{
    class Garden
    {
        private List<Plant> listOfPlants = new List<Plant>();
        private double wateringAmount;

        public List<Plant> ListOfPlants { get; set; }        
        public double WateringAmount { get; set; }

        
    }
}
