using System;
using System.Collections.Generic;

namespace Algorithms.Recursion
{
    public class SubsetSum
    {
        /// <summary>
        /// https://takeuforward.org/data-structure/subset-sum-sum-of-all-subsets
        /// Calculates all possible subset sums of the given array.
        /// Time Complexity: O(2^N) because each element has 2 choices.
        /// Space Complexity: O(2^N) to store the sums, plus O(N) recursion stack.
        /// </summary>
        public IList<int> SubsetSums(int[] nums)
        {
            List<int> subsets = new List<int>();
            // Start recursion from index 0 with an initial sum of 0
            FindSubsets(0, 0, nums.Length, nums, subsets);

            // Sorting the result is often required by competitive platforms (like GFG)
            subsets.Sort();
            return subsets;
        }

        /// <summary>
        /// Helper method to perform recursive backtracking.
        /// </summary>
        /// <param name="index">The current element we are considering.</param>
        /// <param name="currSum">The running total of the current subset.</param>
        /// <param name="n">Total number of elements in nums.</param>
        /// <param name="nums">The input array.</param>
        /// <param name="subsets">The list capturing all final sums.</param>
        private void FindSubsets(int index, int currSum, int n, int[] nums, List<int> subsets)
        {
            // BASE CASE: We have made a decision for every element in the array.
            if (index == n)
            {
                subsets.Add(currSum);
                return;
            }

            // RECURSIVE STEP 1: "Pick" the current element.
            // Add nums[index] to the sum and move to the next index.
            FindSubsets(index + 1, currSum + nums[index], n, nums, subsets);

            // RECURSIVE STEP 2: "Don't Pick" the current element.
            // Keep the currSum as is and move to the next index.
            FindSubsets(index + 1, currSum, n, nums, subsets);
        }
    }
}