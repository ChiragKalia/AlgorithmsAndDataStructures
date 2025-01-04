using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class GridUniquePaths
    {
        /*
        * Problem Statement: Given a matrix m X n, count paths from left-top to the right bottom of a matrix with the constraints that from each cell you can either only move to the rightward direction or the downward direction.
        * https://leetcode.com/problems/unique-paths/
        * https://takeuforward.org/data-structure/grid-unique-paths-count-paths-from-left-top-to-the-right-bottom-of-a-matrix/
        */
        public static int UniquePaths(int m, int n)
        {
            int N = n + m - 2;
            int r = Math.Min(m - 1, n - 1); // Choose the smaller to reduce iteration count
            long res = 1; // Use long to handle larger values
            for (int i = 1; i <= r; i++)
            {
                res *= (N - r + i);
                res /= i;
            }
            return (int)res; // Cast to int as the final result
        }
    }
}
