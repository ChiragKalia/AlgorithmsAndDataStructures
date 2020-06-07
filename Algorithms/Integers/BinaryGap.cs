using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Integers
{
    //Find longest sequence of zeros in binary representation of an integer.
    //https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
    public class BinaryGap
    {
        //A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

        public static int FindBiggestBinaryGap(int N)
        {
            string binary = Convert.ToString(N, 2);
            char[] charArr = binary.ToCharArray();
            bool startingOneExists = false;
            int counter = 0;
            int maxCount = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '1' && startingOneExists == false)
                {
                    startingOneExists = true;
                }
                else if (charArr[i] == '1' && startingOneExists == true)
                {
                    if (maxCount < counter) maxCount = counter;
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }
            return maxCount;
        }
    }
}
