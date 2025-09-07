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
            long n = nums.Length;
            //S - SN (here we are taking the difference between sum of numbers in
            //the array and sum of n natural numbers) 
            long S = nums.Sum(), SN = (n * (n + 1)) / 2;
            //S2 - S2N (difference of square sum of numbers in array and sum of
            //square of n natural numbers)
            long S2 = nums.Sum(z=>z*z), S2N = (n * (n + 1) * (2 * n + 1)) / 6;

            long val1 = S - SN; //x - y
            long val2 = S2 - S2N;
            val2 = val2 / val1; // x + y
            long x = (int)(val1 + val2) / 2;
            long y = x - val1;
            return new int[] { (int)x, (int)y };
        }
    }
}
