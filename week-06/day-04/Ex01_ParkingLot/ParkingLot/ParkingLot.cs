using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class ParkingLot
    {
        public List<Car> GenerateCars()
        {
            int carNumber = 256;
            Random random = new Random();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carNumber; i++)
            {
                cars.Add(new Car((Car.CarColor)random.Next(1, 10), (Car.CarType)random.Next(1, 10)));
            }

            return cars;
        }

        public void CountByType(List<Car> cars)
        {
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
        }

        public void CountByTypeWithLambda(List<Car> cars)
        {
            var sameTypeLambda = cars.GroupBy(car => car.type).ToDictionary(car => car.Key, car => car.Count());

            foreach (var itemTypeLambda in sameTypeLambda)
            {
                Console.WriteLine(itemTypeLambda);
            }
        }

        public void CountByColor(List<Car> cars)
        {
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
        }

        public void MostFrequentlyWtihLambda(List<Car> cars)
        {
            var mostFrequentlyLambda = (cars.GroupBy(car => new { car.type, car.color }).OrderByDescending(car => car.Count()).ToDictionary(car => car.Key, car => car.Count())).First();

            Console.WriteLine(mostFrequentlyLambda);
        }

        public void CountByColorWithLambda(List<Car> cars)
        {
            var sameColorLambda = cars.GroupBy(car => car.color).ToDictionary(car => car.Key, car => car.Count());

            foreach (var itemColorLambda in sameColorLambda)
            {
                Console.WriteLine(itemColorLambda);
            }
        }

        public void MostFrequently(List<Car> cars)
        {
            var mostFrequently = (from carMost in cars
                                  group carMost by new { carMost.type, carMost.color } into selectMost
                                  orderby selectMost.Count() descending
                                  select new
                                  {
                                      selectMost.Key,
                                      Count = (from carType in selectMost select carType).Count()
                                  }).First();

            Console.WriteLine(mostFrequently);
        }
    }
}
