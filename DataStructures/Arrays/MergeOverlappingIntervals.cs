using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class MergeOverlappingIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            List<int[]> result = new List<int[]>();
            intervals = intervals.OrderBy(i => i[0]).ToArray();
            int j = 0; //ToTraverse result Array;
            for (int i = 0; i < intervals.Length; i++)
            {
                if (result.Count == 0)
                {
                    if (i < intervals.Length - 1 && intervals[i][1] >= intervals[i + 1][0])
                    {
                        if (intervals[i][0] == 0 && intervals[i][1] == 0 && intervals[i + 1][0] != 0 && intervals[i + 1][1] != 0)
                        {
                            //write both to result
                            result.Add(intervals[i]);
                            result.Add(intervals[i + 1]);
                        }
                        else if (intervals[i + 1][0] == 0 && intervals[i + 1][1] == 0 && intervals[i][0] != 0 && intervals[i][1] != 0)
                        {
                            //write both to result
                            result.Add(intervals[i + 1]);
                            result.Add(intervals[i]);
                        }
                        else if (intervals[i][0] == 0 && intervals[i][1] == 0 && intervals[i + 1][0] == 0 && intervals[i + 1][1] == 0)
                        {
                            result.Add(intervals[i]);
                        }
                        else
                        {
                            int smallerFirst = (intervals[i][0] > intervals[i + 1][0]) ? intervals[i + 1][0] : intervals[i][0];
                            int biggerSecond = (intervals[i][1] > intervals[i + 1][1]) ? intervals[i][1] : intervals[i + 1][1];
                            result.Add(new int[] { smallerFirst, biggerSecond });
                        }
                        i++;
                    }
                    else
                    {
                        result.Add(intervals[i]);
                    }
                }
                else
                {
                    if (result[j] != null)
                    {
                        if (result[j][1] >= intervals[i][0])
                        {
                            if (intervals[i][0] == 0 && intervals[i][1] == 0 && result[j][0] != 0)
                            {
                                var temp = result[j];
                                result.RemoveAt(j);
                                result.Add(intervals[i]);
                                result.Add(temp);
                            }
                            else
                            {
                                int smallerFirst = (result[j][0] > intervals[i][0]) ? intervals[i][0] : result[j][0];
                                int biggerSecond = (result[j][1] > intervals[i][1]) ? result[j][1] : intervals[i][1];
                                result[j] = new int[] { smallerFirst, biggerSecond };
                            }
                        }
                        else
                        {
                            result.Add(intervals[i]); j++;
                        }
                    }
                    else
                    {
                        result[j] = intervals[i];
                    }
                }
            }
            return result.ToArray();
        }
    }
}
