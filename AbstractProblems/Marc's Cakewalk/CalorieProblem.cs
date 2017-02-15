using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProblems.MarcsCakewalk
{
    public class CalorieProblem
    {
        public long calculateMinimumNumberOfMiles(int[] A, int length)
        {
            long minimumNumberOfMiles = 0L;
            A = A.OrderByDescending(c => c).ToArray();
            for(int i = 0; i< length; i++)
            {
                minimumNumberOfMiles = minimumNumberOfMiles + (long)(A[i] * Math.Pow(2, i));
            }
            return minimumNumberOfMiles;
        }
    }
}
