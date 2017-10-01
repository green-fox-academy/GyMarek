using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Fleet_of_things
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fleet = new Fleet();
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            var thing1 = new Thing("Get Milk");
            var thing2 = new Thing("Remove the obstacles");
            var thing3 = new Thing("Stand up");
            var thing4 = new Thing("Eat lunch");

            fleet.Add(thing1);
            fleet.Add(thing2);
            fleet.Add(thing3);
            fleet.Add(thing4);
            thing3.Complete();
            thing4.Complete();

            fleet.Print();
            Console.ReadKey();
        }
    }
}
