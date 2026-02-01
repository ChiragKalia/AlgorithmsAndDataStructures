using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Recursion
{
    public class PalindromePartitioning
    {
        /// <summary>
        /// https://leetcode.com/problems/palindrome-partitioning/
        /// Partitions a string such that every substring in the partition is a palindrome.
        /// Strategy: Backtracking with a "Scanning Blade" (For-Loop) to try all possible cuts.
        /// Time Complexity: O(N * 2^N) - In worst case (e.g., "aaaa"), there are 2^N possible partitions.
        /// Space Complexity: O(N) for the recursion stack depth.
        /// </summary>
        public IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> result = new List<IList<string>>();
            // We start at index 0, looking for the first valid palindromic prefix.
            FindPalindromes(0, s, new List<string>(), result);
            return result;
        }

        private void FindPalindromes(int index, string s, IList<string> path, IList<IList<string>> result)
        {
            // BASE CASE: If index reaches string length, we have successfully 
            // partitioned the entire string into palindromes.
            if (index == s.Length)
            {
                // Create a deep copy (snapshot) of the current path.
                result.Add(new List<string>(path));
                return;
            }

            // THE LOOP: Acts as a "cutting blade". It tries to cut a substring 
            // starting from 'index' and ending at 'i'.
            for (int i = index; i < s.Length; ++i)
            {
                // 1. VALIDATION: Only proceed if the current "cut" results in a palindrome.
                if (IsPalindrome(s, index, i))
                {
                    // 2. ACTION: Extract the substring. 
                    // Formula: Length = (EndIndex - StartIndex) + 1.
                    string substr = s.Substring(index, i - index + 1);

                    path.Add(substr);

                    // 3. EXPLORE: Recurse to handle the remaining part of the string.
                    // The next starting point is the position immediately after our cut (i + 1).
                    FindPalindromes(i + 1, s, path, result);

                    // 4. UNDO (Backtrack): Remove the last added substring to explore 
                    // the next possible cut length in the loop.
                    // We use RemoveAt(Count-1) for O(1) efficiency and LIFO integrity.
                    path.RemoveAt(path.Count - 1);
                }
            }
        }

        /// <summary>
        /// Helper to check if a range within a string is a palindrome.
        /// Uses the Two-Pointer technique for O(N) efficiency.
        /// </summary>
        private bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start++] != s[end--])
                {
                    return false;
                }
            }
            return true;
        }
    }
}