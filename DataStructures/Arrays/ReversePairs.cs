using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class ReversePairs
    {
        /*
        * Problem Statement: Given an array of numbers, you need to return the count of reverse pairs. Reverse Pairs are those pairs where i<j and arr[i]>2*arr[j].
        * https://leetcode.com/problems/reverse-pairs/
        * https://takeuforward.org/data-structure/count-reverse-pairs/
        */
        public int CountReversePairs(int[] nums)
        {
            // Handle edge case: if the array is empty, there are no reverse pairs
            if (nums.Length == 0) return 0;

            // Initiate the modified merge sort and count reverse pairs
            return MergeSort(nums, 0, nums.Length - 1);
        }

        int MergeSort(int[] nums, int low, int high)
        {
            int count = 0;

            // Base case: if the range contains only one element, no split is possible
            if (low < high)
            {
                // Find the middle point of the range
                int mid = (low + high) / 2;

                // Recursively count reverse pairs in the left and right subarrays
                count += MergeSort(nums, low, mid);
                count += MergeSort(nums, mid + 1, high);

                // Count reverse pairs between the left and right subarrays
                count += CountPairs(nums, low, mid, high);

                // Merge the two sorted halves
                Merge(nums, low, mid, high);
            }

            return count;
        }

        int CountPairs(int[] nums, int low, int mid, int high)
        {
            int right = mid + 1; // Pointer to the start of the second sorted half
            int count = 0;       // Initialize the count of reverse pairs

            // Traverse the left subarray
            for (int i = low; i <= mid; i++)
            {
                // Increment the right pointer while reverse pair condition is satisfied
                while (right <= high && nums[i] > 2L * nums[right]) right++;

                // Add the count of valid pairs for the current element in the left subarray
                count += (right - (mid + 1));
            }

            return count;
        }

        void Merge(int[] nums, int low, int mid, int high)
        {
            // Temporary array to store the merged result
            int[] temp = new int[high - low + 1];
            int left = low, right = mid + 1, k = 0; // Pointers for left, right halves and temp array

            // Merge the two sorted halves
            while (left <= mid && right <= high)
            {
                if (nums[left] <= nums[right])
                {
                    temp[k++] = nums[left++]; // Copy smaller element from the left subarray
                }
                else
                {
                    temp[k++] = nums[right++]; // Copy smaller element from the right subarray
                }
            }

            // Copy any remaining elements from the left subarray
            while (left <= mid)
            {
                temp[k++] = nums[left++];
            }

            // Copy any remaining elements from the right subarray
            while (right <= high)
            {
                temp[k++] = nums[right++];
            }

            // Copy the merged array back into the original array
            for (int i = 0; i < temp.Length; i++)
            {
                nums[low + i] = temp[i];
            }
        }

    }
}
