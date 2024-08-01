using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BitManipulation
{
    public class ReturnNumberOfOnesInBinary
    {
        //<summary>
        // A function that returns number of one's(1) in a binary number
        //</summary>
        //<param name="a">binary number e.g(011)</param>
        public static int numSetBits(long a)
        {
            int count = 0;
            while(a>0)
            {
                int rem = Convert.ToInt32(a%10);
                if(rem !=0)
                {
                    count++;
                }
                a = a / 10;
            }
            return count;
        }
    }
}
