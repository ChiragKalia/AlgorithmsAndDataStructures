using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Integers
{
    public class ReverseInteger
    {
        public static int Reverse(int x)
        {
            int result = 0;
            if (x > Int32.MaxValue || x < Int32.MinValue)
            {
                return result;
            }
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (pop > Int32.MaxValue-1%10)
                    return 0;
                if (pop < Int32.MinValue%10)
                    return 0;
                result = result * 10 + pop;
            }
            return result;
        }
    }
}
