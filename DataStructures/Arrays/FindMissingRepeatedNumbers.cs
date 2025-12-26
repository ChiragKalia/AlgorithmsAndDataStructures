using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class FindMissingRepeatedNumbers
    {
        /*
         * Problem Statement: You are given a read-only array of N integers with values also in the range [1, N] both inclusive. Each integer appears exactly once except A which appears twice and B which is missing. The task is to find the repeating and missing numbers A and B where A repeats twice and B is missing.
         * https://takeuforward.org/data-structure/find-the-repeating-and-missing-numbers/
         * https://www.youtube.com/watch?v=2D0D8HE6uak
         */
        public static int[] FindMissingRepeatingNumber(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                int correctIndex = nums[i] - 1;

                // Condition 1: Is the number NOT in its right home?
                // Condition 2: Is its home NOT already occupied by its twin?
                if (nums[i] != nums[correctIndex])
                {
                    int temp = nums[i];
                    nums[i] = nums[correctIndex];
                    nums[correctIndex] = temp;
                }
                else
                {
                    i++;
                }
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != j + 1)
                {
                    // ALWAYS return the VALUE first, then the EXPECTED value
                    return new int[] { nums[j], j + 1 };
                }
            }
            return new int[0];
        }
    }
}
