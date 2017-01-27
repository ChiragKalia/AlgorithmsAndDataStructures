using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class InsertionSorter
    {
        public int[] InsertionSortold(int[] A, int length)
        {
            for (int j = 1; j < length-1; j++)
            {
                int key = A[j];
                int i = j-1;
                while (i > 0 && A[i] > A[j])
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                    A[i] = key;
                }
            }
            return A;
        }
        public int[] InsertionSort(int[] A, int length)
        {
            for (int j = 1; j < length - 1; j++)
            {
                
                int key = A[j];
                int i = j;
                while (i > 0 && A[i-1] > key)
                {
                    A[i] = A[i-1];
                    i = i - 1;
                }
                A[i] = key;
            }
            return A;
        }

    }
}
