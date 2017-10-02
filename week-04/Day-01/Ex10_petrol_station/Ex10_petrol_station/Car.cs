using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_petrol_station
{
    class Car
    {
        private int gasAmount;
        private int capacity;

        public Car()
        {
            gasAmount = 0;
            capacity = 100;
        }

        public int GasAmount
        {
            get
            {
                return gasAmount;
            }
            set
            {
                gasAmount = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
    }
}
