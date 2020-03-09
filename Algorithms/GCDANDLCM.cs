using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class GCDANDLCM
    {
        static int LCM(int a, int b)
        {
            int indexA = 1;
            int indexB = 1;
            int aMultiple = a;
            int bMultiple = b;
            int LCM = 0;
            while (true)
            {
                aMultiple = a * indexA;
                bMultiple = b * indexB;
                if (aMultiple == bMultiple)
                {
                    LCM = aMultiple;
                    break;
                }
                else if (aMultiple < bMultiple)
                    indexA++;
                else
                    indexB++;
            }
            return LCM;
        }
        static int GCD(int a, int b)
        {
            int smallerNumber = a < b ? a : b;
            int index = 1;
            int biggestDen = 1; //By Default every number is divisible by 1
            while (index < smallerNumber)
            {
                if (a % (index + 1) == 0 && b % (index + 1) == 0)
                {
                    biggestDen = ++index;
                }
                index++;
            }
            return biggestDen;
        }
        static int GCDRecursive(int a, int b, int index, int denominator)
        {
            int smallerNumber = a < b ? a : b;
            if (index < smallerNumber)
            {
                if (a % (index + 1) == 0 && b % (index + 1) == 0)
                {
                    denominator = ++index;
                }
                index++;
                return GCDRecursive(a, b, index, denominator);
            }
            else
            {
                return denominator;
            }
        }
    }
}
