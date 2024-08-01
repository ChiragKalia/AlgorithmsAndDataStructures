using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Integers
{
    public class SingleNumber
    {
        public static int FindSingleNumber(int[] nums)
        {
            int uniqueNumber = 0;
            foreach (int i in nums)
            {
                uniqueNumber ^= i;
            }
            return uniqueNumber;
        }
    }
}
