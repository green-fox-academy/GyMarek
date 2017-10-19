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
            ParkingLot parkingLot = new ParkingLot();

            List<Car> cars = parkingLot.GenerateCars();
            parkingLot.CountByType(cars);
            Console.WriteLine();
            parkingLot.CountByTypeWithLambda(cars);
            Console.WriteLine();
            parkingLot.CountByColor(cars);
            Console.WriteLine();
            parkingLot.CountByColorWithLambda(cars);
            Console.WriteLine();
            parkingLot.MostFrequently(cars);
            Console.WriteLine();
            parkingLot.MostFrequentlyWtihLambda(cars);
            Console.ReadKey();
        }        
    }
}
