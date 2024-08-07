using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class UniquePaths
    {
        /*
         * To Be Revisited
         * Problem Statement: Given a matrix m X n, count paths from left-top to the right bottom of a matrix with the constraints that from each cell you can either only move to the rightward direction or the downward direction.
         * https://leetcode.com/problems/unique-paths/
         * https://takeuforward.org/data-structure/grid-unique-paths-count-paths-from-left-top-to-the-right-bottom-of-a-matrix/
         * https://www.youtube.com/watch?v=t_f0nwwdg5o
         */
        public static int GridUniquePaths(int m, int n)
        {
            int N = (m + n - 2);
            int r = (n - 1);
            double res = 1;

            for (int i = 1; i <= r; i++)
            {
                res = res * (N - r + i) / i;
            }
            return (int)res;
        }
    }
}
