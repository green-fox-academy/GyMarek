using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            int carNumber = 256;
            Random random = new Random();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carNumber; i++)
            {
                cars.Add(new Car(((Car.CarColor)random.Next(typeof(Car.CarColor).GetEnumNames().Length)),
                ((Car.CarType)random.Next(typeof(Car.CarType).GetEnumNames().Length))));
            }
                        
            Console.ReadKey();
        }
    }
}
