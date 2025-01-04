using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    public class MooresVotingII
    {
        /*
         * Given an integer array of size n, find all elements that appear more than n/3 times.
         * https://takeuforward.org/data-structure/majority-elementsn-3-times-find-the-elements-that-appears-more-than-n-3-times-in-the-array/
         * https://www.youtube.com/watch?v=vwZj1K0e9U8
         * https://leetcode.com/problems/majority-element-ii/
         */

        public static IList<int> FindMajorityElements(int[] nums)
        {
            int cnt1 = 0, cnt2 = 0;
            int? el1 = null, el2 = null; // Using nullable int to avoid default value issues

            // Phase 1: Identify potential candidates
            foreach (var num in nums)
            {
                if (el1.HasValue && num == el1)
                {
                    cnt1++;
                }
                else if (el2.HasValue && num == el2)
                {
                    cnt2++;
                }
                else if (cnt1 == 0)
                {
                    el1 = num;
                    cnt1 = 1;
                }
                else if (cnt2 == 0)
                {
                    el2 = num;
                    cnt2 = 1;
                }
                else
                {
                    cnt1--;
                    cnt2--;
                }
            }

            // Phase 2: Verify candidates
            cnt1 = 0;
            cnt2 = 0;

            foreach (var num in nums)
            {
                if (el1.HasValue && num == el1)
                {
                    cnt1++;
                }
                else if (el2.HasValue && num == el2)
                {
                    cnt2++;
                }
            }

            var result = new List<int>();
            int threshold = nums.Length / 3;
            if (cnt1 > threshold && el1.HasValue) result.Add(el1.Value);
            if (cnt2 > threshold && el2.HasValue) result.Add(el2.Value);

            return result;
        }
    }
}
