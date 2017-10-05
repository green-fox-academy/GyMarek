using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Garden
{
    public class Plant
    {
        public string color;
        public double currentWaterAmount;
        public double wateringTreshold;
        public double waterPull;
        public string type;

        //public string Color { get; set; }
        //public double CurrentWaterAmount { get; set; }
        //public double WaterPull { get; set; }
        //public double WateringTreshold { get; }
        //public string Type { get; }

        public virtual void Water(double waterAmount)
        {
            currentWaterAmount += waterAmount;
        }
    }
}
