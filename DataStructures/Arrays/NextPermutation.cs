using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class NextPermutation
    {
        /*Problem Statement: Given an array arr[] of integers, rearrange the numbers of the given array into the lexicographically next greater permutation of numbers.

        If such an arrangement is not possible, it must rearrange to the lowest possible order(i.e., sorted in ascending order).*/
        //https://takeuforward.org/data-structure/next_permutation-find-next-lexicographically-greater-permutation/
        //https://leetcode.com/problems/next-permutation/
        //https://www.youtube.com/watch?v=JDOXKqF60RQ

        static int[] FindNextPermutation(int[] arr)
        {
            int bpIndex = -1; //Break point Index
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] < arr[i + 1])
                {
                    bpIndex = i;
                    break;
                }
            }
            if (bpIndex == -1)
            {
                arr = arr.Reverse().ToArray();
            }
            for (int i = arr.Length - 1; i > bpIndex; i--)
            {
                if (arr[i] > arr[bpIndex])
                {
                    int temp = arr[bpIndex];
                    arr[bpIndex] = arr[i];
                    arr[i] = temp;
                    break;
                }
            }
            Array.Reverse(arr, bpIndex + 1, arr.Length - bpIndex - 1);
            return arr;
        }
    }
}
