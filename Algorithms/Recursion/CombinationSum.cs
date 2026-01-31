using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Recursion
{
    public class CombinationSum
    {
        /// <summary>
        /// https://leetcode.com/problems/combination-sum/
        /// Finds all unique combinations where the chosen numbers sum to the target.
        /// You may choose the same number an unlimited number of times.
        /// Time Complexity: O(2^t * k) where t is the target and k is average length of combination.
        /// Space Complexity: O(k * x) where x is the number of combinations.
        /// </summary>
        public IList<IList<int>> findCombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            // Start exploring from index 0 with an empty list of choices
            FindCombinations(0, candidates, target, new List<int>(), result);
            return result;
        }

        private void FindCombinations(int index, int[] candidates, int target, IList<int> ds, IList<IList<int>> result)
        {
            // BASE CASE 1: We have reached the end of the candidates array.
            if (index == candidates.Length)
            {
                // If we reached the end and the target is exactly 0, we found a valid combination!
                if (target == 0)
                {
                    // Snapshots: We use .ToList() (or new List<int>(ds)) to create a deep copy 
                    // because 'ds' will be emptied during backtracking.
                    result.Add(new List<int>(ds));
                }
                return;
            }

            // BASE CASE 2: The target has been met exactly. Stop Recursion and record the combination.
            if (target == 0)
            {
                result.Add(new List<int>(ds));
                return;
            }

            // RECURSIVE OPTION 1: "Pick" the current element.
            // We only do this if the candidate value isn't already larger than our remaining target.
            if (candidates[index] <= target)
            {
                // Action: Add the element to our current "path"
                ds.Add(candidates[index]);

                // Explore: Stay at the SAME index because we are allowed to reuse the same number!
                // We reduce the target by the value of the candidate we just picked.
                FindCombinations(index, candidates, target - candidates[index], ds, result);

                // Undo (Backtrack): Remove the last element added to "clean up" the list 
                // before we go back up and try the "Don't Pick" option.
                ds.RemoveAt(ds.Count - 1);
            }

            // RECURSIVE OPTION 2: "Don't Pick" the current element.
            // We move to the next index and keep the target exactly as it is.
            FindCombinations(index + 1, candidates, target, ds, result);
        }
    }
}