//the time and space complexity is O(log(n)) and O(1)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BitManipulation
{
    public class DecimalToBinary
    {
        //<summary>
        // A function that returns binary representation of a decimal number //E.g 3 to 011
        //</summary>
        //<param name="n">Decimal number</param>
        public string GetBinaryFromDecimal(long n)
        {
            string binaryNumber = "";
            while(n>0)
            {
                int rem = (int)n%2;
                if(rem==0)
                {
                    binaryNumber = "0"+binaryNumber;
                }
                else
                {
                    binaryNumber = "1" + binaryNumber;
                }
                n = n / 2;
            }
            return binaryNumber;
        }
        /* Return the number of integers within the range [A..B] that are divisible by K.
        Args:

        A: is an integer within the range [0..2,000,000,000]
        B: is an integer within the range [0..2,000,000,000] and A <= B
        K: is an integer within the range [1..2,000,000,000]
        Time complexity must be O(1). */
        public int ReturnDivisibleByK(int A, int B, int K)
        {
            return ((B - A) / K + 1);
        }

    }
}
