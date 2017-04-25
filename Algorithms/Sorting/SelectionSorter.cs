using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SelectionSorter
    {
        public int[] performSelectionSort(int[] A, int n)
        {
            int start = 0;
            for(int i= start; i<n; i++)
            {
                int maxValue = Int32.MaxValue;
                int swapIndex = 0;
                for(int j=start; j<n; j++)
                {
                    if(A[j]< maxValue)
                    {
                        maxValue = A[j];
                        swapIndex = j;
                    }
                }
                int tempVal = A[start];
                A[start] = maxValue;  //e.g 10+5=15; 
                A[swapIndex] = tempVal;
                start += 1;
            }
            return A;
        }
    }
}
