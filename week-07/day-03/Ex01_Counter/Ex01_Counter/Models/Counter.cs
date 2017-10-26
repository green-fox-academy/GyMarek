using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex01_Counter.Models
{
    public class Counter
    {
        public int Number { get; set; }

        public void Raise()
        {
           Number++;
        }
    }
}
