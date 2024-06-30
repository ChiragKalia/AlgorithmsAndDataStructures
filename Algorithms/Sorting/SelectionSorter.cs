using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class SelectionSorter
    {
        public int[] performSelectionSort(int[] arr)
        {
            int sortIndex = 0;
            while (sortIndex <= arr.Length - 1)
            {
                int minIndex = sortIndex;
                for (int i = sortIndex + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[minIndex])
                    {
                        minIndex = i;
                    }
                }
                //swap
                int temp = arr[sortIndex];
                arr[sortIndex] = arr[minIndex];
                arr[minIndex] = temp;
                sortIndex++;
            }
            return arr;
        }
    }
}
