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
            long nn = n;
            if (nn < 0) nn = -1 * nn;
            double ans = 1.0;
            while (nn > 0)
            {
                if (nn % 2 == 0)
                {
                    x = x * x;
                    nn = nn / 2;
                }
                else
                {
                    ans = x * ans;
                    nn--;
                }
            }
            if (n < 0) ans = 1 / ans;
            return ans;
        }
    }
}
