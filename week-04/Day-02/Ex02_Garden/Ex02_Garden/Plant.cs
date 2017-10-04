using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Garden
{
    public class Plant
    {
        protected string color;
        protected double currentWaterAmount;
        protected double wateringTreshold;
        protected string type;

        public string Color { get; set; }
        public double CurrentWaterAmount { get; set; }
        public double WateringTreshold { get; }
        public string Type { get; }

        public virtual void Water(double waterAmount)
        {
            currentWaterAmount += waterAmount;
        }
    }
}
