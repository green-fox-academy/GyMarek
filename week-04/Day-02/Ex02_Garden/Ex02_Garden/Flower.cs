using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Garden
{
    public class Flower : Plant
    {
        public Flower(string color)
        {
            this.wateringTreshold = 5;
            this.waterPull = 0.75;
            this.currentWaterAmount = 0;
            this.type = "Flower";
            this.color = color;
        }
        public override void Water(double waterAmount)
        {
            currentWaterAmount += waterAmount * waterPull;
        }
    }
}
