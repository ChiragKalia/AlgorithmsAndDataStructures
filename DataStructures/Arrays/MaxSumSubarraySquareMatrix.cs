using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class MaxSumSubarraySquareMatrix
    {
        //This method will return the maximum sum of a subarray in a square matrix
        public static int CalculateMaxSum(int [,] A, int n)
        {
            int maxSum = 0;
            for(int i=0; i<n; i++)
            {
                int iterationSum = 0;
                int currentSum = 0;
                for(int j=0; j<n; j++)
                {
                    currentSum = currentSum + A[i, j];
                    if (currentSum < 0)
                    {
                        currentSum = 0;
                    }
                    if (iterationSum < currentSum)
                    {
                        iterationSum = currentSum;
                    }
                }
                if (maxSum < iterationSum)
                {
                    maxSum = iterationSum;
                }
                currentSum = 0;
            }
            return maxSum;
        }
    }
}
