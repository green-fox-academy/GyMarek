using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            CounterApp counterApp = new CounterApp();
            
            counterApp.Add(5); 
            counterApp.Add();
            Console.WriteLine(counterApp.GetCounter());

            counterApp.ResetCouter();
            Console.WriteLine(counterApp.GetCounter());

            Console.ReadKey();
        }
    }
}