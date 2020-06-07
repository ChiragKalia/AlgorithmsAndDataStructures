using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class RotateMatrixClockwise
    {
        public void RotateMatrix(ref int[,] A, int n) // This method will rotate a matrix by 90degrees clockwise. //Params -1) Array 2) Size of matrix.
        {
            //Incomplete will work for only 2*2 matrix for now. //Will update for more.
            int last = n - 1;
            int totalNumberOfLevels = n/2;
            int level = 0;
            while(level<totalNumberOfLevels)
            {
                for (int i = level; i < last; i++)
                {
                    SwapVars.Swap(ref A[level, i], ref A[i, last]);
                    SwapVars.Swap(ref A[level, i], ref A[last, last-i+level]);
                    SwapVars.Swap(ref A[level, i], ref A[last - i + level, level]);
                    //PrintMatrix.Print2DMatrix(A, n);
                }
                ++level;
                --last;
            }
        }
        public static int[,] RotateMatrix90Clockwise(int[,] matrix)
        {
            int len = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(matrix.Length)));
            int[,] result = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    result[i, j] = matrix[len - j - 1, i];
                }
            }
            return result;
        }
        public static int[,] RotateMatrix90CWInPlace(int[,] matrix)
        {
            int n = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(matrix.Length)));
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, n - j - 1];
                    matrix[i, n - j - 1] = temp;
                }
            }
            return matrix;
        }

        public static int[,] RotateMatrix90AntiClockwise(int[,] matrix)
        {
            int n = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(matrix.Length)));
            int[,] result = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = matrix[j, n - i - 1];
                }
            }
            return result;
        }
        public static int[,] RotateMatrix180Clockwise(int[,] matrix)
        {
            int n = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(matrix.Length)));
            int[,] result = new int[n, n];
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    result[n - i - 1, n - j - 1] = matrix[i, j];
                }
            }
            return result;
        }
    }
}
