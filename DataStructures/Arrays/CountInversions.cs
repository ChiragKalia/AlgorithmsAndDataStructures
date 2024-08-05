using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class CountInversions
    {
        /*
         * Problem Statement: Given an array of N integers, count the inversion of the array (using merge-sort).
         * https://takeuforward.org/data-structure/count-inversions-in-an-array/
         * https://www.youtube.com/watch?v=AseUmwVNaoY
         */
        public static int CountInversionsInArray(int[] arr, int n)
        {
            return MergeSort(arr, 0, n);
        }

        public static int MergeSort(int[] arr, int low, int high)
        {
            int cnt = 0;
            if (low != high)
            {
                //First Divide
                int mid = (low + high) / 2;
                cnt += MergeSort(arr, low, mid);
                cnt += MergeSort(arr, mid + 1, high);
                //merge
                cnt += Merge(arr, low, mid, high);
            }
            return cnt;
        }

        public static int Merge(int[] arr, int low, int mid, int high)
        {
            List<int> temp = new List<int>();
            int left = low;
            int right = mid + 1;
            int cnt = 0;
            while (left <= mid && right <= high)
            {
                if (arr[left] <= arr[right])
                {
                    temp.Add(arr[left++]);
                }
                else
                {
                    cnt += (mid - left + 1);
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
            return cnt;
        }
    }
}
