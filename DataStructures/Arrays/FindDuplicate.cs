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
         *  This solution utilizes Floyd's Tortoise and Hare algorithm to detect cycle in the linked list.
         */
        public static int FindTheDuplicate(int[] nums)
        {
            int tortoise = nums[0];
            int hare = nums[0];
            do
            {
                tortoise = nums[tortoise];
                hare = nums[nums[hare]];
            } while (tortoise != hare);

            hare = nums[0];
            while (tortoise != hare)
            {
                tortoise = nums[tortoise];
                hare = nums[hare];
            }
            return tortoise;
        }
    }
}
