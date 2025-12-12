using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class Anagram
    {
        //Sorting the characters of both strings
        //Complexity: O(n log n)
        // Because sorting the characters of the strings takes O(n log n) time.
        public static bool CheckIfAnagram(string s1, string s2)
        {
            char[] c1 = s1.ToLower().ToCharArray();
            char[] c2 = s2.ToLower().ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            s1 = new string(c1);
            s2 = new string(c2);

            if (s1 == s2)
            {
                return true;
            }
            return false;
        }

        //Using a dictionary to count character occurrences.
        bool AreAnagrams(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in s1.ToLower())
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            foreach (char c in s2.ToLower())
            {
                if (!charCounts.ContainsKey(c))
                {
                    return false;
                }
                charCounts[c]--;

                if (charCounts[c] == 0)
                {
                    charCounts.Remove(c);
                }
            }

            return charCounts.Count == 0;
        }

    }
}
