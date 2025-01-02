using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class PowerExponentiation
    {
        /*
         * Problem Statement: Given a double x and integer n, calculate x raised to power n. Basically Implement pow(x, n).
         * https://takeuforward.org/data-structure/implement-powxn-x-raised-to-the-power-n/
         * https://www.youtube.com/watch?v=l0YC3876qxg        
         * https://leetcode.com/problems/powx-n/
         */

        public static double MyPow(double x, int n)
        {
            double ans = 1.0;
            long nn = Math.Abs((long)n);
            while (nn > 0)
            {
                if (nn % 2 == 1)
                {
                    ans *= x;
                    nn--;
                }
                else
                {
                    x *= x;
                    nn /= 2;
                }
            }
            if (n < 0) ans = 1 / ans;
            return ans;
        }
    }
}
