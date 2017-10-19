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

            //Generate Random Car List
            for (int i = 0; i < carNumber; i++)
            {
                cars.Add(new Car((Car.CarColor)random.Next(1, 10), (Car.CarType)random.Next(1, 10)));
            }

            //Query Type
            var sameType = from carType in cars
                           group carType by carType.type into selectType
                           select new
                           {
                               selectType.Key,
                               Count = (from carType in selectType select carType).Count()
                           };

            foreach (var itemType in sameType)
            {
                Console.WriteLine(itemType);
            }

            Console.WriteLine();

            //Method Type
            var sameTypeLambda = cars.GroupBy(car => car.type).ToDictionary(car => car.Key, car => car.Count());

            foreach (var itemTypeLambda in sameTypeLambda)
            {
                Console.WriteLine(itemTypeLambda);
            }

            Console.WriteLine();

            //Query Color
            var sameColor = from carColor in cars
                           group carColor by carColor.color into selectColor
                           select new
                           {
                               selectColor.Key,
                               Count = (from carType in selectColor select carType).Count()
                           };

            foreach (var itemColor in sameColor)
            {
                Console.WriteLine(itemColor);
            }

            Console.WriteLine();

            //Method Color
            var sameColorLambda = cars.GroupBy(car => car.color).ToDictionary(car => car.Key, car => car.Count());

            foreach (var itemColorLambda in sameColorLambda)
            {
                Console.WriteLine(itemColorLambda);
            }

            Console.ReadKey();
        }
    }
}
