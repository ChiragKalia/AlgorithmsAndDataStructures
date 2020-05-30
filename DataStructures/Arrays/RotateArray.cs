using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class RotateArray
    {
        public static void LeftRotateArray(int[] arr, int pivot, int n)
        {
            for (int i = 0; i < pivot; i++)
            {
                int swap = arr[0];
                for (int j = 0; j < n - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[n - 1] = swap;
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
