using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class MaximumDistance
    {
        public int GetMaximumDiff(List<int> A)
        {
            int n = A.Count;
            int start = 0;
            int end = 1;
            int maxDiff = 0;
            int currentDiff = 0;
            if(n==1)
            {
                return 0;
            }
            else
            {
                while (start < end)
                {
                    if (start < n)
                    {
                        if (end < n)
                        {
                            if (A[start] <= A[end])
                            {
                                currentDiff = end - start;
                            }
                            end++;
                        }
                        else
                        {
                            start++;
                            end = start + 1;
                            if (maxDiff == -1)
                            {
                                maxDiff = currentDiff;
                            }
                            else if (currentDiff > maxDiff)
                            {
                                maxDiff = currentDiff;
                            }
                            currentDiff = -1;
                        }
                    }
                    else
                    {
                        start = end;
                    }
                }
                return maxDiff;

            }
        }
    }
}
