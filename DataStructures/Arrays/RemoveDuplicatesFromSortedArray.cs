using System;

namespace DataStructures.Arrays
{
    public class RemoveDuplicatesFromSortedArray
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
        /// Removes duplicates from a sorted array in-place.
        /// Strategy: Two-Pointers (Slow and Fast).
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="nums">The sorted input array.</param>
        /// <returns>The number of unique elements.</returns>
        public int RemoveDuplicates(int[] nums)
        {
            // Edge Case: If the array is empty, there are 0 unique elements.
            if (nums.Length == 0) return 0;

            // uniqPtr (Slow): Points to the last known unique element.
            int uniqPtr = 0;

            // currPtr (Fast): Scans the array looking for new values.
            // We start at 1 because the element at index 0 is always "unique" to start.
            int currPtr = 1;

            while (currPtr < nums.Length)
            {
                // If the current element is different from our last unique element...
                if (nums[currPtr] != nums[uniqPtr])
                {
                    // 1. Move the slow pointer forward to the next available slot.
                    // 2. Write the new unique value into that slot.
                    nums[++uniqPtr] = nums[currPtr];
                }

                // Always move the scout pointer forward.
                currPtr++;
            }

            // Since uniqPtr is 0-indexed, the total count is uniqPtr + 1.
            return uniqPtr + 1;
        }
    }
}