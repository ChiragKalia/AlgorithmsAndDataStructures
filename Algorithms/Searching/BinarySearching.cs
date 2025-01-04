using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    public class BinarySearching
    {
        private static int index = -1;
        //<summary>
        // A function that returns index of inputted element in a sorted array if found, Otherwise returns -1
        //</summary>
        //<param name="A">Sorted Array</param>
        //<param name="n">Length of Array</param>
        //<param name="x">Element to be searched</param>
        public static int GetElementIndex(int[] A,int n, int x) 
        {
            int start = 0;
            int end = n-1;
            int mid = GetMiddleElement(start, end);
            index = ApplyBinarySearch(A, start, mid, end,x);
            return index;
        }
        //<summary>
        // A function that returns index of inputted element in a sorted array if found, Otherwise returns -1
        //</summary>
        //<param name="A">Sorted Array</param>
        //<param name="start">Starting index of array</param>
        //<param name="mid">Middle index of array</param>
        //<param name="end">Ending index of array</param>
        //<param name="x">Element to be searched</param>
        private static int ApplyBinarySearch(int[] A, int start, int mid, int end, int x)
        {
            if(index == -1)
            {
                if (x == A[mid])
                {
                    index = mid;
                }
                else if (x < A[mid])
                {
                    end = mid - 1;
                    mid = GetMiddleElement(start, end);
                    ApplyBinarySearch(A, start, mid, end, x);
                }
                else if (x > A[mid])
                {
                    start = mid + 1;
                    mid = GetMiddleElement(start, end);
                    ApplyBinarySearch(A, start, mid, end, x);
                }
            }
            return index;
        }
        //<summary>
        // A function that returns middle element
        //</summary>
        //<param name="start">Starting index of array</param>
        //<param name="end">Ending index of array</param>
        private static int GetMiddleElement(int start, int end)
        {
            return (start + end) / 2;
        }
    }
}
