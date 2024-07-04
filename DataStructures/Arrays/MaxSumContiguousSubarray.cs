using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class MaxSumContiguousSubarray
    {
        /*  Problem Statement: Given an integer array arr, find the contiguous subarray (containing at least one number) which
            has the largest sum and returns its sum and prints the subarray.
         */
        //https://takeuforward.org/data-structure/kadanes-algorithm-maximum-subarray-sum-in-an-array/
        //https://www.youtube.com/watch?v=AHZpyENo7k4
        public static int MaxSubArrayUsingKadane(int[] arr)
        {

            int max = Int32.MinValue;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                max = (sum > max) ? sum : max;
                if (sum < 0) sum = 0;
            }
            return max;
        }
    }
}

