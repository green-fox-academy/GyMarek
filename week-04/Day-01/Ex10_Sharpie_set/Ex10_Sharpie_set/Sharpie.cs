using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Sharpie_set
{
    class Sharpie
    {
        private string name;
        private string color;
        private float width;
        private float inkAmount = 100;
        private bool usable;

        public Sharpie(string color, float width, string name)
        {
            this.name = name;
            this.color = color;
            this.width = width;
        }

        public float InkAmount
        {
            get
            {
                return inkAmount;
            }
        }

        public void Use()
        {
            inkAmount -= 100;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        public bool Usable
        {
            get
            {
                return usable;
            }
            set
            {
                usable = value;
            }
        }
    }
}
