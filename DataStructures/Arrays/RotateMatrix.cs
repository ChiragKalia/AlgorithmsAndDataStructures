using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class RotateMatrix
    {
        /*
         * https://takeuforward.org/data-structure/rotate-image-by-90-degree/
         * https://www.youtube.com/watch?v=Z0R2u6gd3GU
         * https://leetcode.com/problems/rotate-image/
         * Problem Statement: Given a matrix, your task is to rotate the matrix
         * 90 degrees clockwise.
         */
        static int[][] Rotate(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = i; j < matrix[i].Length; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                Array.Reverse(matrix[i]);
            }
            return matrix;
        }

    }
}
