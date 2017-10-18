using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
                "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var startEndCitiesQuery = from city in cities
                                 where city.StartsWith("A") && city.EndsWith("I")
                                 select city;

            foreach (var selectCity in startEndCitiesQuery)
            {
                Console.WriteLine(selectCity);
            }

            Console.WriteLine();

            var startEndCitiesLambda = cities.Where(x => x.StartsWith("A") && x.EndsWith("I"));

            foreach (var selectCity2 in startEndCitiesLambda)
            {
                Console.WriteLine(selectCity2);
            }

            Console.ReadKey();
        }
    }
}
