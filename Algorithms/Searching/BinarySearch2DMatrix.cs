using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    public class BinarySearch2DMatrix
    {
        /*
         * Problem Statement: You have been given a 2-D array 'mat' of size 'M * N' where 'M' and 'N' denote the number of rows and columns, respectively. The elements of each row are sorted in non-decreasing order. Moreover, the first element of a row is greater than the last element of the previous row (if it exists). You are given an integer ‘target’, and your task is to find if it exists in the given 'mat' or not.

         * https://www.youtube.com/watch?v=JXU4Akft7yk
         * https://leetcode.com/problems/search-a-2d-matrix
         * https://takeuforward.org/data-structure/search-in-a-sorted-2d-matrix/
         */
        public static bool SearchJaggedMatrix(int[][] mat, int target)
        {
            int low = 0;
            int m = mat.Length;
            int n = mat[0].Length;
            int high = m * n - 1;

            while (low <= high)
            {

                int mid = (low + high) / 2;
                int midVal = mat[mid / n][mid % n];
                if (midVal == target)
                {
                    return true;
                }
                else if (midVal >= target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return false;
        }


        public static bool Search2DMatrix(int[,] mat, int target)
        {
            int low = 0;
            int high = mat.Length - 1;

            while (low <= high)
            {

                int mid = (low + high) / 2;
                int row = mid / mat.GetLength(1); // index/m(no. of cols) 
                int col = mid % mat.GetLength(1); // index/m(no. of rows)

                if (mat[row, col] == target)
                {
                    return true;
                }
                else if (mat[row, col] >= target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return false;
        }
    }
}
