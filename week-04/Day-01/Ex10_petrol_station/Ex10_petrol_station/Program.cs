using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_petrol_station
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Station and Car classes
            //Station
            //  GasAmount
            //  Refill(car)->decreases the gasAmount by the capacity of the car and increases the cars gasAmount
            //Car
            //  GasAmount
            //  Capacity
            //  create constructor for Car where:
            //      initialize gasAmount-> 0
            //      initialize capacity-> 100

            Car MyCar = new Car();
            Station NewStation = new Station();
            NewStation.Refill(MyCar);
            Console.WriteLine("Station new gas amount: " + NewStation.GasAmount + 
                " My Car new gas amount: " + MyCar.GasAmount);
            Console.ReadLine();



        }
    }
}
