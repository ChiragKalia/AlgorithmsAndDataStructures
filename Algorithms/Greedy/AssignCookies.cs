using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Greedy
{
    public class AssignCookies
    {
        /// <summary>
        /// https://leetcode.com/problems/assign-cookies/
        /// Maximizes the number of content children by assigning cookies greedily.
        /// Strategy: Sort both arrays and use two pointers to match the smallest 
        /// effective cookie to the least greedy child.
        /// Time Complexity: O(N log N + M log M) due to sorting.
        /// Space Complexity: O(1) or O(log N) depending on the sorting implementation.
        /// </summary>
        int AssignMaxCookies(int[] greed, int[] cookies)
        {
            // 1. Sort both to enable the two-pointer greedy approach
            Array.Sort(greed);
            Array.Sort(cookies);

            int childPointer = 0;  // Index for children (greed)
            int cookiePointer = 0; // Index for cookies

            // 2. Iterate until we run out of either children or cookies
            while (childPointer < greed.Length && cookiePointer < cookies.Length)
            {
                // If the current cookie can satisfy the current child
                if (cookies[cookiePointer] >= greed[childPointer])
                {
                    // Child is satisfied, move to the next child
                    childPointer++;
                }

                // Regardless of whether the child was satisfied, 
                // we move to the next cookie because the current one 
                // is either used or too small to ever be useful for remaining children.
                cookiePointer++;
            }

            // The number of children satisfied is exactly our childPointer index
            return childPointer;
        }
    }
}
