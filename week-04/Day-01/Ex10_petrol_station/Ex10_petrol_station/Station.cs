using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_petrol_station
{
    class Station
    {
        private int gasAmount = 200;

        public int GasAmount
        {
            get
            {
                return gasAmount;
            }
        }
        public void Refill(Car car)
        {
            gasAmount -= car.Capacity;
            car.GasAmount += car.Capacity;
        }
    }
}