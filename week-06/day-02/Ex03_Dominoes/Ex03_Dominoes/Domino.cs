using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Dominoes
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo (object obj)
        {
            Domino otherDomino = obj as Domino;

            if (Values[0]==otherDomino.Values[0])
            {
                return this.Values[1].CompareTo(otherDomino.Values[1]);
            }
            else
            {
                return this.Values[0].CompareTo(otherDomino.Values[0]);
            }
        }       

        public override string ToString()
        {
            return $"({Values[0]}, {Values[1]})";
        }
    }
}
