using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class MaximumHourglassSum
    {
        //This method calculates the hourglass sum for every hourglass in a 6*6 array, then print the maximum hourglass sum.
        //FYI: Hourglass= a b c
        //                  d
        //                e f g
        //e.g if input =                1 1 1 0 0 0
        //                              0 1 0 0 0 0
        //                              1 1 1 0 0 0
        //                              0 0 2 4 4 0
        //                              0 0 0 2 0 0
        //                              0 0 1 2 4 0 
        //Then Output = 19 because out of 16 hourglass combinations the hourglass with the maximum sum () is:
        //                              2 4 4
        //                                2
        //                              1 2 4
        public int GetMaximumHourglassSum(int[][] A)
        {
            int n = A.Length;
            int maxSum = A[0][0];
            for(int i=0; i<n/2+1; i++)
            {
                for (int j = 0; j < n / 2 + 1; j++)
                {
                    int currentSum = A[i][j]    + A[i][j + 1]       + A[i][j + 2]
                                                + A[i+1][j+1]
                                   + A[i+2][j]   + A[i + 2][j + 1]   + A[i + 2][j + 2];
                    if (currentSum > maxSum || maxSum == A[0][0])
                    {
                        maxSum = currentSum;
                    }
                }
            }
            return maxSum;
        }
    }
}
