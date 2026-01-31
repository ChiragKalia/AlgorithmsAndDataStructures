using System;
using System.Collections.Generic;

namespace Algorithms.Recursion
{
    public class SubsetsII
    {
        /// <summary>
        /// https://leetcode.com/problems/subsets-ii/description/
        /// Generates all unique subsets (the power set) of an array that may contain duplicates.
        /// Time Complexity: O(N * 2^N) - We generate 2^N subsets and copy each into the result.
        /// Space Complexity: O(N * 2^N) - To store the subsets, plus O(N) recursion stack.
        /// </summary>
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            // 1. Sorting is crucial: It groups identical elements together,
            // which allows us to identify and skip duplicates easily.
            Array.Sort(nums);

            IList<IList<int>> resList = new List<IList<int>>();

            // Start the recursive exploration
            FindSubsets(0, nums, new List<int>(), resList);

            return resList;
        }

        private void FindSubsets(int index, int[] nums, IList<int> ds, IList<IList<int>> resList)
        {
            // 2. Add current state to result: Every node in our recursion tree is a valid subset.
            // We create a 'new List' (Deep Copy) because 'ds' is a reference that changes as we backtrack.
            resList.Add(new List<int>(ds));

            // 3. Loop through remaining elements to branch out
            for (int i = index; i < nums.Length; i++)
            {
                // 4. Duplicate Check: If we are at the same recursion level and the current
                // element is the same as the previous, skip it to avoid duplicate subsets.
                if (i != index && nums[i] == nums[i - 1]) continue;

                // 5. Choose: Add current element to our path
                ds.Add(nums[i]);

                // 6. Explore: Recurse to the next index to build on this subset
                FindSubsets(i + 1, nums, ds, resList);

                // 7. Backtrack: Remove the last element added so we can explore
                // other branches with a clean slate at this level.
                ds.RemoveAt(ds.Count - 1);
            }
        }
    }
}