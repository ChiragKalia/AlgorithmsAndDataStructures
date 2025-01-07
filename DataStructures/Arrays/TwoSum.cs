using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class TwoSum
    {
        /*
        * Problem Statement: Given an array of integers arr[] and an integer target.
        * https://leetcode.com/problems/two-sum/
        * https://takeuforward.org/data-structure/two-sum-check-if-a-pair-with-given-sum-exists-in-array/
        */
        public int[] FindTwoSum(int[] nums, int target)
        {
            // Initialize a dictionary to store the index of each element as we iterate through the array.
            Dictionary<int, int> dict = new Dictionary<int, int>();

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {

                // Calculate the number required to complement the current element to form the target sum.
                int requiredElement = target - nums[i];

                // Check if the required element (the complement) already exists in the dictionary.
                if (dict.ContainsKey(requiredElement))
                {
                    // If found, return the indices of the complement and the current element.
                    return new int[] { dict[requiredElement], i };
                }
                else
                {
                    // If not found, add the current element along with its index to the dictionary.
                    dict[nums[i]] = i;
                }
            }

            return new int[] { -1, -1 };
        }

        public bool HasTwoSum(int[] nums, int target)
        {
            // Sort the array to use the two-pointer technique.
            Array.Sort(nums);

            // Initialize two pointers: 'left' at the start (beginning of array) and 'right' at the end (end of array).
            int left = 0;
            int right = nums.Length - 1;

            // Use a while loop to iterate as long as the left pointer is less than the right pointer.
            while (left < right)
            {

                // Calculate the sum of the elements at the left and right pointers.
                int currSum = nums[left] + nums[right];

                // If the current sum equals the target, return true as we have found the pair.
                if (currSum == target)
                {
                    return true;
                }
                // If the current sum is less than the target, increment the 'left' pointer to increase the sum.
                else if (currSum < target)
                {
                    left++;
                }
                // If the current sum is greater than the target, decrement the 'right' pointer to reduce the sum.
                else
                {
                    right--;
                }
            }

            // If no such pair is found, return false.
            return false;
        }
    }
}
