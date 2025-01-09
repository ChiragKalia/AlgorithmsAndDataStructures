using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class LargestSubarray0Sum
    {
        /*
        *Problem Statement: Given an array containing both positive and negative integers, we have to find the length of the longest subarray with the sum of all elements equal to zero.
        * https://www.geeksforgeeks.org/problems/largest-subarray-with-0-sum/1
        * https://takeuforward.org/data-structure/length-of-the-longest-subarray-with-zero-sum/
        */
        public int LongestSubarray(int[] nums)
        {
            int longest = 0;  // Tracks the longest subarray with sum 0
            int sum = 0;      // Tracks the cumulative sum of elements
            Dictionary<int, int> prefixSumIndices = new Dictionary<int, int>(); // Stores the first occurrence of each prefix sum
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                // If cumulative sum is zero, the entire subarray from start to i has a sum of zero
                if (sum == 0)
                {
                    longest = i + 1;
                }
                else
                {
                    // Check if the current sum was seen before
                    if (prefixSumIndices.ContainsKey(sum))
                    {
                        // Calculate the subarray length since the first occurrence of this sum
                        longest = Math.Max(longest, (i - (prefixSumIndices[sum])));
                    }
                    else
                    {
                        // Store the first occurrence of this sum
                        prefixSumIndices.Add(sum, i);
                    }

                }
            }
            return longest;
        }

    }
}
