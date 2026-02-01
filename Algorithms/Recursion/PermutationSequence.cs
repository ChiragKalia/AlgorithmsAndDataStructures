using System;
using System.Collections.Generic;

namespace Algorithms.Recursion
{
    public class PermutationSequence
    {
        /// <summary>
        /// https://leetcode.com/problems/permutation-sequence/
        /// Finds the kth permutation sequence of numbers from 1 to n.
        /// Logic: Uses mathematical deduction (Factoradic) instead of generating all permutations.
        /// Time Complexity: O(N^2) due to list removals inside the loop.
        /// Space Complexity: O(N) to store the numbers list.
        /// </summary>
        public string FindKthPermutation(int n, int k)
        {
            int factorial = 1;
            List<int> numbers = new List<int>();

            // 1. Initial Setup:
            // Fill a list with numbers [1, 2, ..., n] 
            // Calculate (n-1)! - this is the "block size" or "bucket size".
            // For n=4, (n-1)! is 6. This means there are 6 permutations starting with '1'.
            for (int i = 1; i < n; i++)
            {
                factorial = factorial * i;
                numbers.Add(i);
            }
            numbers.Add(n);

            // 2. 0-based indexing:
            // We subtract 1 from k because computers use 0-based indexing.
            // If n=3 and k=3, we want the sequence at index 2.
            k = k - 1;
            string ans = "";

            // 3. The "Bucket" Loop:
            // We determine one digit at a time from left to right.
            while (numbers.Count > 0)
            {
                // Identify which 'block' the k-th permutation belongs to.
                // index = k / (total perms for remaining digits)
                int index = k / factorial;

                // Append the chosen number to our result string.
                ans += numbers[index];

                // CRITICAL: Remove the used number from the list.
                // This shifts the remaining numbers, keeping the relative order correct.
                numbers.RemoveAt(index);

                // Exit condition: no more numbers left to place.
                if (numbers.Count == 0) break;

                // 4. Update state for the next digit:
                // New k is the remainder within the current block.
                k = k % factorial;

                // New factorial is the block size for the next position (divide by remaining elements).
                factorial = factorial / numbers.Count;
            }

            return ans;
        }
    }
}