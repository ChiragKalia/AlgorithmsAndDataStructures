using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class MergeSorter
    {
        //Uses Divide & Conquer Strategy. 
        /*
         * https://www.youtube.com/watch?v=ogjf7ORKfd8&t=3s
         * We don't want to create temp arrays when recursing so playing with index instead
         */
        public static int[] MergeSort(int[] arr, int low, int high)
        {
            if (low != high)
            {
                //First Divide
                int mid = (low + high) / 2;
                MergeSort(arr, low, mid);
                MergeSort(arr, mid + 1, high);
                //merge
                Merge(arr, low, mid, high);
            }
            return arr;
        }

        public static int[] Merge(int[] arr, int low, int mid, int high)
        {
            List<int> temp = new List<int>();
            int left = low;
            int right = mid + 1;
            while (left <= mid && right <= high)
            {
                if (arr[left] <= arr[right])
                {
                    temp.Add(arr[left++]);
                }
                else
                {
                    temp.Add(arr[right++]);
                }
            }
            while (left <= mid)
            {
                temp.Add(arr[left++]);
            }
            while (right <= high)
            {
                temp.Add(arr[right++]);
            }
            for (int i = low; i <= high; i++)
            {
                arr[i] = temp[i - low];
            }
            return arr;
        }
    }
}
