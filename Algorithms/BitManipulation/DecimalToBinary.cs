using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BitManipulation
{
    public class DecimalToBinary
    {
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
    }
}
