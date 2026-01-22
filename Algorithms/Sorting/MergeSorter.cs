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
        public int[] MergeSort(int[] nums, int low, int high)
        {
            // Base case: if the range is 1 element or less, it's already sorted
            if (low >= high) return nums;

            // Calculate the middle point
            int mid = low + (high - low) / 2;

            // Recursive calls
            MergeSort(nums, low, mid);
            MergeSort(nums, mid + 1, high);

            // Merge the sorted halves
            return Merge(nums, low, mid, high);
        }

        private int[] Merge(int[] nums, int low, int mid, int high)
        {
            List<int> temp = new List<int>();
            int left = low;
            int right = mid + 1;

            // Standard merge logic
            while (left <= mid && right <= high)
            {
                if (nums[left] > nums[right])
                {
                    temp.Add(nums[right++]);
                }
                else
                {
                    temp.Add(nums[left++]);
                }
            }

            // Collect remaining elements
            while (left <= mid) temp.Add(nums[left++]);
            while (right <= high) temp.Add(nums[right++]);

            foreach (int num in temp)
            {
                nums[low++] = num; // Assigns then increments low
            }

            return nums;
        }
    }
}
