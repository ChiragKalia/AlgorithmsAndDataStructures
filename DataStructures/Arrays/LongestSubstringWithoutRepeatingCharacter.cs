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
            int len = 0;
            if (s.Length == 0) { return len; }

            int left = 0;
            Dictionary<char, int> frequencyDict = new Dictionary<char, int>();

            for (int right = 0; right < s.Length; right++)
            {
                if (frequencyDict.ContainsKey(s[right]))
                {
                    left = Math.Max(left, frequencyDict[s[right]] + 1); // Move the left pointer
                }
                frequencyDict[s[right]] = right; // Update the character's index
                len = Math.Max(len, right - left + 1); // Update the maximum length
            }

            return len;
        }
    }
}
