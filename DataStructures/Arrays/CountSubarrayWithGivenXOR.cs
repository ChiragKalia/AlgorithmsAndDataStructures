using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class CountSubarrayWithGivenXOR
    {
        /*Problem Statement: Given an array of integers A and an integer B. Find the total number of subarrays having bitwise XOR of all elements equal to k.
         * https://takeuforward.org/data-structure/count-the-number-of-subarrays-with-given-xor-k/
         * https://www.youtube.com/watch?v=eZr-6p0B7ME
         * https://www.interviewbit.com/problems/subarray-with-given-xor/
         */
        public int NumberSubarraysWithXorK(int[] nums, int K)
        {
            int count = 0;
            // Dictionary to store the frequency of XOR values computed so far
            Dictionary<int, int> xorFrequency = new Dictionary<int, int>
            {
                { 0, 1 } // To handle cases where a subarray directly matches `k`
            };

            int xr = 0; // This will store the cumulative XOR of elements so far

            for (int i = 0; i < nums.Length; i++)
            {
                // Update the cumulative XOR with the current element
                xr ^= nums[i];

                // Calculate the XOR needed to get a subarray XOR equal to K
                int x = xr ^ K;

                // If this required XOR exists in the map, add its frequency to the count
                if (xorFrequency.ContainsKey(x))
                {
                    count += xorFrequency[x];
                }

                // Update the frequency of the current cumulative XOR in the map
                if (xorFrequency.ContainsKey(xr))
                {
                    xorFrequency[xr] += 1;
                }
                else
                {
                    xorFrequency.Add(xr, 1);
                }
            }

            return count;
        }
    }
}
