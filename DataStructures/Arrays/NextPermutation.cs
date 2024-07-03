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
        //https://www.youtube.com/watch?v=JDOXKqF60RQ

        static int[] FindNextPermutation(int[] arr)
        {
            int n = arr.Length;
            int index = -1;
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] < arr[i + 1])
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                Array.Reverse(arr);
            }

            Console.WriteLine("Index: " + index);
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] > arr[index])
                {
                    Console.WriteLine("Greater index: " + i + " value: " + arr[i]);
                    int temp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = temp;
                    break;
                }
            }

            int endIndex = n - 1;
            index++;
            while (index < endIndex)
            {
                int temp = arr[index];
                arr[index] = arr[endIndex];
                arr[endIndex] = temp;
                index++;
                endIndex--;
            }
            return arr;
        }
    }
}
