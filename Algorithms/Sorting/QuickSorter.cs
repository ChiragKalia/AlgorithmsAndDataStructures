using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class QuickSorter
    {
        void swap(int[] A, int i, int j)
        {
            int swapVal = A[i];
            A[i] = A[j];
            A[j] = swapVal;
        }
        int partition(int[] A, int start, int end) //Hi All in this method we'll implement quick sort using randomized pivot selector which'll almost always have the worst case complexity of 0(nlogn)
        {
            int pivot = A[end];
            int partitionIndex = start;
            for(int i=start; i<end; i++)
            {
                if(A[i]<= pivot)
                { //Swap if element is lesser than pivot
                    swap(A, i, partitionIndex);
                    partitionIndex++;
                }
            }
            swap(A, partitionIndex, end);
            return partitionIndex;
        }
        public void quickSort(int[] A, int start,int end)
        {

        }
    }
}
