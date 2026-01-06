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
        public IList<IList<int>> FindFourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int n = nums.Length;
            if (n < 4) return result;
            // Sort the array to facilitate the two-pointer approach and handle duplicates
            Array.Sort(nums);
            // Outer loop for the first element of the quadruplet 
            // Only need to go up to n - 3 because we need at least 4 elements.
            for (int i = 0; i < n-3; i++)
            {
                // Skip duplicates for the first element
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                // --- PRUNING FOR i ---
                // 1. Current nums[i] is so small that even with the 3 largest numbers, it can't reach target
                if ((long)nums[i] + nums[n - 1] + nums[n - 2] + nums[n - 3] < target) continue;
                // 2. Current nums[i] is so large that even with the 3 smallest numbers, it exceeds target
                if ((long)nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target) break;

                // Second loop for the second element of the quadruplet
                // Only need to go up to n - 2
                for (int j = i + 1; j < n-2; j++)
                {
                    // Skip duplicates for the second element
                    if (j != i + 1 && nums[j] == nums[j - 1]) continue;

                    // --- PRUNING FOR j ---
                    if ((long)nums[i] + nums[j] + nums[n - 1] + nums[n - 2] < target) continue;
                    if ((long)nums[i] + nums[j] + nums[j + 1] + nums[j + 2] > target) break;

                    // Initialize two pointers for the remaining two elements
                    int k = j + 1; int l = n - 1;
                    // Use the two-pointer technique to find pairs that sum to target
                    while (k < l)
                    {
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
                            k++;
                        }
                        else
                        {
                            l--;
                        }
                    }
                }
            }
            return result;
        }

    }
}
