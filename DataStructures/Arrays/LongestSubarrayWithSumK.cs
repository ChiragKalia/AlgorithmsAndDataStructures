using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class LongestSubarrayWithSumK
    {
        /// <summary>
        /// Works for ALL integers (Positives, Negatives, and Zeros).
        /// Time Complexity: O(N) | Space Complexity: O(N)
        /// </summary>
        public int LongestSubarrayWithSum(int[] nums, int target)
        {
            if (nums.Length == 0) return 0;

            int longest = 0;
            int currSum = 0;

            // Key: Prefix Sum | Value: The EARLIEST index where this sum occurred
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                currSum += nums[i];

                // If the sum from the very beginning equals target
                if (currSum == target)
                {
                    longest = i + 1;
                }

                // If (currSum - target) exists in map, the subarray between 
                // that old index and current index 'i' sums to target.
                int neededGap = currSum - target;
                if (map.ContainsKey(neededGap))
                {
                    longest = Math.Max(longest, i - map[neededGap]);
                }

                // GREEDY RULE: Only store the sum if we haven't seen it before.
                // Keeping the earliest index ensures the subarray is as long as possible.
                if (!map.ContainsKey(currSum))
                {
                    map.Add(currSum, i);
                }
            }

            return longest;
        }

        /// <summary>
        /// ONLY works for non-negative integers (Positives and Zeros).
        /// Time Complexity: O(N) | Space Complexity: O(1)
        /// </summary>
        int LongestSubarrayWithSumKPositives(int[] nums, int target)
        {
            int left = 0;
            int currSum = 0;
            int longest = 0;

            // 'right' pointer expands the window to explore new elements
            for (int right = 0; right < nums.Length; right++)
            {
                currSum += nums[right];

                // GREEDY SHRINK: If the sum is too large, move the 'left' pointer 
                // forward to reduce the sum. Because numbers are positive, 
                // we know moving 'left' will always decrease the sum.
                while (currSum > target && left <= right)
                {
                    currSum -= nums[left];
                    left++;
                }

                // If the window hits the target exactly, calculate its length
                if (currSum == target)
                {
                    // length = (end_index - start_index + 1)
                    longest = Math.Max(longest, right - left + 1);
                }
            }

            return longest;
        }
    }

}
