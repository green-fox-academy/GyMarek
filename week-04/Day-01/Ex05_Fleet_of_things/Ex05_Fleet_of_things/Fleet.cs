using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Fleet_of_things
{
    public class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public void Print()
        {
            foreach (Thing item in Things)
            {
                if (item.IsCompleted())
                {
                    Console.WriteLine("[X] " + item.GetName());
                }
                else
                {
                    Console.WriteLine("[ ] " + item.GetName());
                }
            }
        }
    }
}
