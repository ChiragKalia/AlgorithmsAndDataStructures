using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class MergeTwoSortedArrays
    {
        public static int[] MergeTwoSortedArraysIntoOne(int[] arr1, int[] arr2, int len1, int len2)
        {
            int[] resultArr = new int[len1 + len2]; //1,1,2,3,4,5
            int i = 0, j = 0, k = 0;
            while (i < len1 && j < len2)
            {
                if (arr1[i] < arr2[j])
                    resultArr[k++] = arr1[i++];
                else
                    resultArr[k++] = arr2[j++];
            }
            while (i < len1)
                resultArr[k++] = arr1[i++];

            // Store remaining elements 
            // of second array 
            while (j < len2)
                resultArr[k++] = arr2[j++];

            return resultArr;
        }
    }
}
