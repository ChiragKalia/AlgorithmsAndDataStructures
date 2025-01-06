using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class FourSum
    {
        /*
        *Given an array of N integers, your task is to find unique quads that add up to give a target value. In short, you need to return an array of all the unique quadruplets [arr[a], arr[b], arr[c], arr[d]] such that their sum is equal to a given target.
        * https://leetcode.com/problems/4sum/
        * https://takeuforward.org/data-structure/4-sum-find-quads-that-add-up-to-a-target-value/
        */
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            // List to store the resulting quadruplets
            IList<IList<int>> result = new List<IList<int>>();
            // Sort the array to facilitate the two-pointer approach and handle duplicates
            Array.Sort(nums);
            // Outer loop for the first element of the quadruplet
            for (int i = 0; i < nums.Length; i++)
            {
                // Skip duplicates for the first element
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                // Second loop for the second element of the quadruplet
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // Skip duplicates for the second element
                    if (j != i + 1 && nums[j] == nums[j - 1]) continue;
                    // Initialize two pointers for the remaining two elements
                    int k = j + 1; int l = nums.Length - 1;
                    // Use the two-pointer technique to find pairs that sum to target
                    while (k < l)
                    {
                        // Calculate the current sum
                        long sum = (long)nums[i] + nums[j] + nums[k] + nums[l];

                        if (sum == target)
                        {
                            // Add the quadruplet to the result if the sum matches the target
                            result.Add(new List<int> { nums[i], nums[j], nums[k], nums[l] });

                            // Move pointers to the next unique elements
                            k++;
                            l--;
                            while (k < l && nums[k] == nums[k - 1]) k++;
                            while (k < l && nums[l] == nums[l + 1]) l--;
                        }
                        else if (sum < target)
                        {
                            // Move the left pointer to increase the sum
                            k++;
                        }
                        else
                        {
                            // Move the right pointer to decrease the sum
                            l--;
                        }
                    }
                }
            }
            return result;
        }

    }
}
