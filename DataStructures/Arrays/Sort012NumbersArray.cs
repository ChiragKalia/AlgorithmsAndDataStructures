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
        https://leetcode.com/problems/sort-colors/
        https://takeuforward.org/data-structure/sort-an-array-of-0s-1s-and-2s/
        https://www.youtube.com/watch?v=tp8JIuCXBaU&list=PLgUwDviBIf0oF6QL8m22w1hIDC1vJ_BHz&index=22
         */

        public static int[] SortColors(int[] arr)
        {
            int low = 0, mid = 0, high = arr.Length;
            while (mid <= high)
            {
                if (arr[mid] == 0)
                {
                    int temp = arr[low];
                    arr[low] = arr[mid];
                    arr[mid] = temp;
                    low++;
                    mid++;
                }
                else if (arr[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    int temp = arr[high];
                    arr[high] = arr[mid];
                    arr[mid] = temp;
                    high--;
                }
            }
            return arr;
        }

    }
}
