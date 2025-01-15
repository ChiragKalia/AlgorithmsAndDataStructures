using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    /* Problem Statement: Given an array containing both positive and negative integers, we have to find the length of the longest subarray with the sum of all elements equal to k.
     * https://www.youtube.com/watch?v=frf7qxiN2qU
     */
    public class LargestSubarrayKSum
    {
        //Only for positives
        public int LargestSubarrayWithSumKPositives(int[] nums, int target)
        {
            int max = 0, currSum = nums[0];
            int i = 0, j = 0;
            while (j < nums.Length)
            {
                while (i <= j && currSum > target)
                {
                    currSum -= nums[i];
                    i++;
                }
                if (currSum == target)
                {
                    max = Math.Max(max, (j - i + 1));
                }
                j++;
                if (j < nums.Length) currSum += nums[j];
            }
            return max;
        }

        public int LargestSubarrayWithSumK(int[] nums, int sum)
        {
            int max = 0, currSum = 0;
            Dictionary<int, int> prefixSumDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                currSum += nums[i];
                if (currSum == sum)
                {
                    max = Math.Max(max, i + 1);
                    if (!prefixSumDict.ContainsKey(currSum))
                    {
                    }
                }
                else if (prefixSumDict.ContainsKey(currSum - sum))
                {
                    max = Math.Max(max, i - prefixSumDict[currSum - sum]);
                }
                if (!prefixSumDict.ContainsKey(currSum))
                    prefixSumDict.Add(currSum, i);
            }
            return max;
        }
    }
}
