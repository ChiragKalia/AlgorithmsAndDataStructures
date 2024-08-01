using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class MergeTwoSortedArrays
    {
        /*
         * Problem statement: Given two sorted arrays nums1[] and nums2[] of sizes m and n in non-decreasing order. Merge them in sorted order. Modify nums1 so that it contains the first M elements and modify nums2 so that it contains the last N elements.
         * https://takeuforward.org/data-structure/merge-two-sorted-arrays-without-extra-space/
         * https://www.youtube.com/watch?v=n7uwj04E0I4
         */
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int left = nums1.Length - 1;
            int right = 0;
            while (left >= 0 && right < nums2.Length)
            {
                if (nums1[left] > nums2[right])
                {
                    //Swap both numbers
                    (nums1[left], nums2[right]) = (nums2[right], nums1[left]);
                    left--; right++;
                }
                else
                {
                    break;
                }
            }
            //Sort them in the end.
            Array.Sort(nums1);
            Array.Sort(nums2);
        }
    }
}
