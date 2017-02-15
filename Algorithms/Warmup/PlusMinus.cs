using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Warmup
{
    public class PlusMinus
    {
        public string[] CountFractions(int length, int[] A)
        {
            string[] fractions = new string[3];
            int numberOfPositives = 0;
            int numberOfNegatives = 0;
            int numberOfZeroes = 0;
            for (int i = 0; i < length; i++)
            {
                if(A[i] < 0)
                {
                    numberOfNegatives++;
                }
                else if(A[i]==0)
                {
                    numberOfZeroes++;
                }
                else
                {
                    numberOfPositives++;
                }
            }
            fractions[0] = ((decimal)numberOfPositives / (decimal)length).ToString("N6");
            fractions[1] = ((decimal)numberOfNegatives / (decimal)length).ToString("N6");
            fractions[2] = ((decimal)numberOfZeroes / (decimal)length).ToString("N6");
            return fractions;
        }
    }
}
