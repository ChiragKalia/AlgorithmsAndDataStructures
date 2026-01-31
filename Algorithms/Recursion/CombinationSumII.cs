using System;
using System.Collections.Generic;

namespace Algorithms.Recursion
{
    public class CombinationSumII
    {
        /// <summary>
        /// https://leetcode.com/problems/combination-sum-ii/
        /// Finds all unique combinations where each number is used ONLY ONCE 
        /// and the sum equals the target.
        /// Time Complexity: O(2^N * k) - where N is number of candidates.
        /// Space Complexity: O(k * x) - k is avg length, x is number of combinations.
        /// </summary>
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            // 1. SORTING is mandatory. It allows us to:
            // a) Break early if a number is too big (pruning).
            // b) Easily skip duplicate numbers sitting next to each other.
            Array.Sort(candidates);

            FindCombinations(0, candidates, target, new List<int>(), result);
            return result;
        }

        private void FindCombinations(int index, int[] candidates, int target, IList<int> ds, IList<IList<int>> result)
        {
            // BASE CASE: If target is 0, we've hit our goal perfectly!
            if (target == 0)
            {
                result.Add(new List<int>(ds)); // Deep copy/Snapshot
                return;
            }

            // 2. THE LOOP: This represents "Horizontal" choices.
            // At this specific depth in the recursion, we try every possible 'next' number.
            for (int i = index; i < candidates.Length; i++)
            {
                // 3. PRUNING: If the current number is already bigger than the target,
                // and because the array is sorted, all numbers after it will also be too big.
                // We 'break' to stop this entire branch early.
                if (candidates[i] > target) break;

                // 4. DUPLICATE SKIP: If we are at the same level (i > index) and 
                // this number is the same as the previous one, skip it.
                // This prevents generating the same combination multiple times.
                if (i > index && candidates[i] == candidates[i - 1]) continue;

                // 5. ACTION: Choose the element
                ds.Add(candidates[i]);

                // 6. EXPLORE: Move to the next index (i + 1) because we can't reuse the same element.
                FindCombinations(i + 1, candidates, target - candidates[i], ds, result);

                // 7. UNDO (Backtrack): Remove the element to try the next 'i' in the loop.
                // ds.RemoveAt(ds.Count - 1) is slightly faster than ds.Remove(val).
                ds.RemoveAt(ds.Count - 1);
            }
        }
    }
}