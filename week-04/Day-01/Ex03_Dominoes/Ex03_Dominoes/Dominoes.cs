using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Dominoes
{
    public class Domino
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}
