using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Car
    {
        public Car(CarColor color,CarType type)
        {
            this.color = color;
            this.type = type;
        }

        public CarColor color { get; set; }
        public CarType type { get; set; }

        public enum CarType
        {
            Honda,
            Suzuki,
            Ford,
            Renault,
            Skoda,
            Bmw,
            Mercedes,
            Audi,
            Dacia,
            Toyota
        }

        public enum CarColor
        {
            Blue,
            Red,
            White,
            Black,
            Yellow,
            Grey,
            Green,
            Pink,
            Orange,
            Purple
        }

        public override string ToString()
        {
            return $"{color}, {type}";
        }
    }
}
