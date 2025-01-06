using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class ThreeSum
    {
        /*
        * Problem Statement: Given an array of N integers, your task is to find unique triplets that add up to give a sum of zero. In short, you need to return an array of all the unique triplets [arr[a], arr[b], arr[c]] such that i!=j, j!=k, k!=i, and their sum is equal to zero.
        * https://leetcode.com/problems/3sum/
        * https://takeuforward.org/data-structure/3-sum-find-triplets-that-add-up-to-a-zero/
        */
        public IList<IList<int>> FindThreeSum(int[] nums)
        {
            // List to store the resulting triplets.
            IList<IList<int>> result = new List<IList<int>>();

            // Sort the array to enable the two-pointer approach and handle duplicates.
            Array.Sort(nums);

            // Iterate through the array to pick the first element of the triplet.
            for (int i = 0; i < nums.Length; i++)  // Only go up to nums.Length - 2
            {
                // Skip duplicate elements to avoid duplicate triplets.
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                // Initialize two pointers: 'j' starts after 'i', and 'k' starts at the end.
                int j = i + 1;
                int k = nums.Length - 1;

                // Use the two-pointer approach to find valid triplets.
                while (j < k)
                {
                    // Calculate the sum of the triplet.
                    long sum = (long)nums[i] + nums[j] + nums[k];

                    if (sum == 0)
                    {
                        // If the sum equals zero, add the triplet to the result list.
                        result.Add(new List<int> { nums[i], nums[j], nums[k] });

                        // Move both pointers to the next unique elements to avoid duplicates.
                        j++;
                        k--;
                        while (j < k && nums[j] == nums[j - 1]) j++;
                        while (j < k && nums[k] == nums[k + 1]) k--;
                    }
                    else if (sum < 0)
                    {
                        // If the sum is less than zero, move the 'j' pointer right to increase the sum.
                        j++;
                    }
                    else
                    {
                        // If the sum is greater than zero, move the 'k' pointer left to decrease the sum.
                        k--;
                    }
                }
            }
            // Return the list of triplets.
            return result;
        }
    }
}
