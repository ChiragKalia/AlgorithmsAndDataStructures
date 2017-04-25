using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SelectionSort
    {
        public int[] performSelectionSort(int[] A, int n)
        {
            int start = 0;
            for(int i= start; i<n; i++)
            {
                int minValue = Int32.MaxValue;
                int swapIndex = 0;
                for(int j=start; j<n; j++)
                {
                    if(A[j]<minValue)
                    {
                        minValue = A[j];
                        swapIndex = j;
                    }
                }
                //Swap two numbers without using temp var
                A[swapIndex] = A[swapIndex] + A[start];  //e.g 10+5=15; 
                A[swapIndex] = A[swapIndex] - A[start]; //15-5 = 10;
                A[start] = A[swapIndex] - A[start]; // 10-5 = 15;
                start += 1;
            }
            return A;
        }
    }
}
