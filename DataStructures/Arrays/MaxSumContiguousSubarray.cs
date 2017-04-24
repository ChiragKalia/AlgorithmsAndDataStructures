using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class MaxSumContiguousSubarray
    {
        public int GetMaximumSum(int[] A, int n) //A is array and n is the number of elements in the array
        {
            int maxSum = 0;
            int currentSum = 0;
            bool areAllNegativeNumbers = true;
            int biggestNegativeNumber = Int32.MinValue;
            for(int i=0; i<n; i++) // This is done using Kadane's algorithm which reduces the complexity to linear time. What an algo (y).
            {
                if(A[i]>0)
                {
                    areAllNegativeNumbers = false;
                }
                else if (A[i] > biggestNegativeNumber)
                {
                    biggestNegativeNumber = A[i];
                }
                currentSum = currentSum + A[i];
                if(currentSum < 0)
                {
                    currentSum = 0;
                }
                if(maxSum<currentSum)
                {
                    maxSum = currentSum;
                }
            }
            if(areAllNegativeNumbers == true)
            {
                return biggestNegativeNumber; //Returns biggest negative number from the list;
            }
            else
            {
                return maxSum;  //Returns sum of maximum contiguous subarray
            }
        }
    }
}
