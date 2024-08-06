using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    public class BinarySearch2DMatrix
    {
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
