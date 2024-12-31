using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class MergeOverlappingIntervals
    {
        /*
         * Problem Statement: Given an array of intervals, merge all the overlapping intervals and return an array of non-overlapping intervals.
         * https://leetcode.com/problems/merge-intervals/
         * https://www.youtube.com/watch?v=IexN60k62jo
         */
        public static int[][] Merge(int[][] intervals)
        {
            // Step 1: Sort intervals by start time
            Array.Sort(intervals, (x, y) => x[0] - y[0]);

            List<int[]> ans = new List<int[]>();
            ans.Add(intervals[0]);
            for (int i = 1; i < intervals.Length; i++)
            {

                if (intervals[i][0] > ans[ans.Count - 1][1])
                {
                    ans.Add(intervals[i]);
                }
                else
                {
                    ans[ans.Count - 1][1] = Math.Max(ans[ans.Count - 1][1], intervals[i][1]);
                }
            }
            return ans.ToArray();
        }
    }
}
