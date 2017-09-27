using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Sum
{
    public class SumList
    {
        public int SumFromList(List<int> list)
        {
            if (list != null)
            {
                return list.Sum();
            }
            return 0;
        }
    }
}
