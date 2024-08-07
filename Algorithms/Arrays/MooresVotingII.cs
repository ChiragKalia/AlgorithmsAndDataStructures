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
            
            int el1 = Int32.MinValue, el2 = Int32.MinValue;
            int cnt1 = 0, cnt2 = 0, n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                if (cnt1 == 0 && nums[i] != el2)
                {
                    cnt1 = 1;
                    el1 = nums[i];
                }
                else if (cnt2 == 0 && nums[i] != el1)
                {
                    cnt2 = 1;
                    el2 = nums[i];
                }
                else if (nums[i] == el1)
                {
                    cnt1++;
                }
                else if (nums[i] == el2)
                {
                    cnt2++;
                }
                else
                {
                    cnt1--; cnt2--;
                }
            }
            cnt1 = 0; cnt2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == el1)
                    cnt1++;
                else if (nums[i] == el2)
                    cnt2++;
            }
            List<int> res = new List<int>();
            if (cnt1 > (nums.Length / 3))
            {
                res.Add(el1);
            }
            if (cnt2 > (nums.Length / 3))
            {
                res.Add(el2);
            }
            return res;
        }
    }
}
