using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class QuickSorter
    {
        void Swap(int[] A, int i, int j)
        {
            int swapVal = A[i];
            A[i] = A[j];
            A[j] = swapVal;
        }
        int Partition(int[] A, int start, int end) //Hi All in this method we'll implement quick sort using randomized pivot selector which'll almost always have the average case complexity of 0(nlogn)
        {
            int pivot = A[end];
            int partitionIndex = start;
            for(int i=start; i<end; i++)
            {
                if(A[i]<= pivot)
                { //Swap if element is lesser than pivot
                    Swap(A, i, partitionIndex);
                    partitionIndex++;
                }
            }
            Swap(A, partitionIndex, end);
            return partitionIndex;
        }
        public void QuickSort(int[] A, int start,int end)
        {
            if(start < end)
            {
                int pIndex = Partition(A, start, end);
                QuickSort(A, start, pIndex - 1);
                QuickSort(A, pIndex + 1, end);
            }
        }
    }
}
