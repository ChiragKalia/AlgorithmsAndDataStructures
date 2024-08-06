using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    public class MooresVoting
    {
        /*
         * Problem Statement: Given an array of N integers, write a program to return an element that occurs more than N/2 times in the given array. You may consider that such an element always exists in the array.
         * https://takeuforward.org/data-structure/find-the-majority-element-that-occurs-more-than-n-2-times/
         * https://www.youtube.com/watch?v=nP_ns3uSh80
         * https://leetcode.com/problems/majority-element/
         */
        public static int FindMajorityElement(int[] nums)
        {
            //We will be using Moore's Voting Algorithm
            int majElem = nums[0];
            int counter = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (counter == 0)
                {
                    majElem = nums[i];
                    counter = 1;
                }
                else if (nums[i] == majElem)
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
            }
            //In case the array doesn't have a majority element.
            //int cnt1 = nums.Where(i => i == majElem).Count();
            //if (cnt1 > nums.Length / 2) return majElem;
            //else return -1;

            if (counter > 0) return majElem;
            else return -1;
        }
    }
}
