using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Sharpie_set
{
    class Sharpie
    {
        public string Color;
        public float Width;
        public float InkAmount = 100;

        public Sharpie(string color, float width, float inkAmount)
        {
            this.Color = color;
            this.Width = width;
            this.InkAmount = inkAmount;
        }

        public float Use()
        {
            return this.InkAmount--;
        }

        public float GetInkAmount()
        {
            return this.InkAmount;
        }
    }
}
