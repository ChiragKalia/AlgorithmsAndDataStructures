using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class LongestSubarrayWithSum
    {
        /// <summary>
        /// Works for ALL integers (Positives, Negatives, and Zeros).
        /// Time Complexity: O(N) | Space Complexity: O(N)
        /// </summary>
        public int LongestSubarrayWithKSum(int[] nums, int target)
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
                if (map.TryGetValue(currSum - target, out int startIndex))
                {
                    longest = Math.Max(longest, i - startIndex);
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
        public int LongestSubarrayWithSumKPositives(int[] nums, int target)
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

        /// <summary>
        /// Finds the length of the longest subarray that sums to zero.
        /// This approach works for any array containing both positive and negative integers.
        /// Logic: If the prefix sum is the same at two different indices, the numbers between 
        /// those indices must have a total sum of zero.
        /// Complexity: Time O(N) | Space O(N)
        /// </summary>
        int LongestSubarrayWithZeroSum(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int longest = 0;
            int currSum = 0;

            // Key: The running sum (prefix sum)
            // Value: The FIRST index where we encountered this specific sum
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // 1. Update the running total
                currSum += nums[i];

                // 2. Check if the sequence starting from the very beginning (index 0) sums to zero
                if (currSum == 0)
                {
                    longest = i + 1;
                }
                else
                {
                    // 3. If we've seen this exact 'currSum' before, it means the sum of 
                    // elements between the previous occurrence and now is zero.
                    if (map.ContainsKey(currSum))
                    {
                        // Calculate the distance between the first occurrence and current index
                        // Note: We don't add 1 here because map[currSum] is the index BEFORE the zero-sum sequence starts
                        longest = Math.Max(longest, i - map[currSum]);
                    }
                    else
                    {
                        // 4. Store the sum with its index. 
                        // GREEDY: We only store the FIRST time we see a sum to ensure we get the longest possible distance.
                        map.Add(currSum, i);
                    }
                }
            }

            return longest;
        }
    }

}
