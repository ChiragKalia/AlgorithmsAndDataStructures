using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class RotateArray
    {
        public static void LeftRotateArray(int[] arr, int pivot, int n)
        {
            for (int i = 0; i < pivot; i++)
            {
                int swap = arr[0];
                for (int j = 0; j < n - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[n - 1] = swap;
            }
        }
        /// <summary>
        /// Rotates the elements of the specified array to the right by the specified number of places.
        /// </summary>
        /// <remarks>The rotation is performed in-place, modifying the input array. If k is 0 or equal to
        /// the length of the array, the array remains unchanged.</remarks>
        /// <param name="nums">The array of integers to rotate. Cannot be null.</param>
        /// <param name="k">The number of positions to rotate the array to the right. Must be between 0 and the length of the array,
        /// inclusive.</param>
        /// <returns>An array containing the rotated elements. If the array has fewer than two elements, the original array is
        /// returned.</returns>
        public int[] RotateArrayByKPlaces(int[] nums, int k)
        {
            int n = nums.Length;
            if (nums.Length < 2) return nums;
            Array.Reverse(nums, 0, n - k);
            Array.Reverse(nums, n - k, k);
            Array.Reverse(nums);
            return nums;
        }
    }
}
