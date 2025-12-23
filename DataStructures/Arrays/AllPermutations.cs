using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Arrays
{
    public class AllPermutations
    {
        //https://leetcode.com/problems/permutations/
        public IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            // Start the recursive process from the first index (0)
            RecurPermute(0, nums, result);
            return result;
        }

        private void RecurPermute(int index, int[] nums, List<IList<int>> result)
        {
            // BASE CASE: If 'index' reaches the end, we have a full permutation
            if (index == nums.Length)
            {
                // We MUST use .ToList() or new List<int>(nums) to create a SNAPSHOT.
                // Since 'nums' is a reference type, storing it directly would only
                // store a reference to an array that keeps changing.
                result.Add(nums.ToList());
                return;
            }

            // Iterate through the array starting from the current 'index'
            // Elements before 'index' are already "fixed" in their positions
            for (int i = index; i < nums.Length; i++)
            {
                // 1. SWAP: Move the element at 'i' to the current 'index' position
                // This "chooses" nums[i] for this spot in the permutation
                Swap(nums, index, i);

                // 2. RECURSE: Move to the next index (index + 1)
                // We pass 'index + 1' as a value so this local 'index' remains unchanged
                RecurPermute(index + 1, nums, result);

                // 3. BACKTRACK (2nd Swap): Undo the previous swap
                // This restores 'nums' to its state before this loop iteration,
                // allowing us to try a different element at the current 'index'
                Swap(nums, index, i);
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            // Standard swap logic using a temporary variable
            // Changes here affect the original array in memory (Pass-by-Reference)
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}