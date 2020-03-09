using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Integers
{
    public class CheckIfPrime
    {
        public bool CheckIfTheNumberIsPrime(int n)
        {
            bool prime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
    }
}
