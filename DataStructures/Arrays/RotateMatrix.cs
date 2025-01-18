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
            // Step 1: Transpose the matrix by swapping elements across its diagonal.
            // For each element at position (i, j), swap it with the element at position (j, i).
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = i + 1; j < matrix[i].Length; j++)
                {
                    // Swap elements matrix[i][j] and matrix[j][i].
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            // Step 2: Reverse each row of the matrix to complete the rotation.
            // This transforms the transposed matrix into the rotated one.
            for (int i = 0; i < matrix.Length; i++)
            {
                // Reverse the current row.
                Array.Reverse(matrix[i]);
            }

            // Return the rotated matrix.
            return matrix;
        }

    }
}
