using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class LongestSubstringWithoutRepeatingCharacter
    {
        /*Problem Statement: Given a String, find the length of longest substring without any repeating character.
         https://leetcode.com/problems/longest-substring-without-repeating-characters/
        https://takeuforward.org/interviews/strivers-sde-sheet-top-coding-interview-problems
        */
        public int LengthOfLongestSubstring(string s)
        {
            if (String.IsNullOrEmpty(s)) return 0;
            int longest = 0;
            HashSet<char> seen = new HashSet<char>();
            int left = 0, right = 0;

            while (right < s.Length)
            {
                if (!seen.Add(s[right]))
                {
                    while (s[left] != s[right])
                    {
                        seen.Remove(s[left]);
                        left++;
                    }
                    left++;
                }

                right++;
                longest = Math.Max(longest, right - left);
            }
            return longest;
        }
    }
}
