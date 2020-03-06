using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class GCD
    {
        static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
            {
                int c = a % b;
                return gcd(b, c);
        }

}
