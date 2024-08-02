using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class FindDuplicate
    {
        /*
         *  Problem Statement: Given an array of N + 1 size, where each element is between 1 and N. Assuming there is only one duplicate number, your task is to find the duplicate number.
         *  https://takeuforward.org/data-structure/find-the-duplicate-in-an-array-of-n1-integers/
         *  https://www.youtube.com/watch?v=32Ll35mhWg0&list=PLgUwDviBIf0rPG3Ictpu74YWBQ1CaBkm2&index=2
         *  https://leetcode.com/problems/find-the-duplicate-number/
         *  #To Be Revisited
         */
        public static int FindTheDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow != fast);

            fast = nums[0];
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }
            return slow;
        }
    }
}
