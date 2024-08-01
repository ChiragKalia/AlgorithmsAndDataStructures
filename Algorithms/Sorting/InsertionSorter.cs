using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class InsertionSorter
    {
        public static int[] performInsertionSort(int[] A, int n) //This function will sort an array using insertion sort.s
        {
            int sortedIndex = 0;
            for(int i=1; i<n; i++)
            {
                if(A[i]<A[sortedIndex])
                {
                    int updatedIndex = i;
                    while (sortedIndex < n && sortedIndex >=0)
                    {
                        if (A[updatedIndex] < A[sortedIndex])
                        {
                            int temp = A[sortedIndex];
                            A[sortedIndex] = A[updatedIndex];
                            A[updatedIndex] = temp;
                            updatedIndex = sortedIndex;
                        }
                        sortedIndex -= 1;
                    }
                }
                sortedIndex = i;
            }
            return A;
        }
    }
}
