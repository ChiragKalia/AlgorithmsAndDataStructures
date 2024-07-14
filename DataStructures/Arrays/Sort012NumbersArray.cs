using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class Sort012NumbersArray
    {
        /*
        Problem Statement: Given an array consisting of only 0s, 1s, and 2s. Write a program to in-place sort the array without using inbuilt sort functions ( Expected: Single pass-O(N) and constant space) 
        https://takeuforward.org/data-structure/sort-an-array-of-0s-1s-and-2s/
        https://www.youtube.com/watch?v=tp8JIuCXBaU&list=PLgUwDviBIf0oF6QL8m22w1hIDC1vJ_BHz&index=22
         */

        public static int[] Sort012Array(int[] arr)
        {
            int n = arr.Length;
            int low = 0;
            int mid = 0;
            int high = n - 1;

            while (mid <= high)
            {
                switch (arr[mid])
                {
                    case 0:
                        (arr[low], arr[mid]) = (arr[mid], arr[low]);
                        low++; mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        (arr[mid], arr[high]) = (arr[high], arr[mid]);
                        high--;
                        break;
                }

            }
            return arr;
        }

    }
}
