using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    public class Pivot1DArray
    {
        public int[] RotateArrayRight(int[] x, int pivot)
        {
            int[] r = x.Skip(pivot).Concat(x.Take(pivot)).ToArray();
            return r;
        }
    }
}
