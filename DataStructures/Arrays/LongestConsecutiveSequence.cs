using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class LongestConsecutiveSequence
    {
        /*
        *Problem Statement: You are given an array of ‘N’ integers. You need to find the length of the longest sequence which contains the consecutive elements.
        * https://leetcode.com/problems/longest-consecutive-sequence/
        * https://takeuforward.org/data-structure/longest-consecutive-sequence-in-an-array/
        */
        public int LongestConsecutive(int[] nums)
        {
            // If the input array is empty, the longest consecutive sequence is 0.
            if (nums.Length == 0)
                return 0;

            int longest = 0;

            // Use a HashSet to store the numbers for O(1) lookup.
            HashSet<int> set = new HashSet<int>(nums);

            foreach (int num in set)
            {
                // Check if the current number is the start of a sequence.
                // A number is the start of a sequence if `num - 1` is not in the set.
                if (!set.Contains(num - 1))
                {
                    int cnt = 1;

                    // Check for subsequent numbers in the sequence.
                    while (set.Contains(num + cnt))
                        cnt++;

                    // Update the longest sequence length if the current sequence is longer.
                    longest = Math.Max(cnt, longest);
                }
            }

            return longest;
        }
    }
}
