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
         * Problem Statement: Given a matrix, your task is to rotate the matrix
         * 90 degrees clockwise.
         */
        static int[,] RotateImage90Degrees(int[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(1) - 1; i++)
            {
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int start = 0;
                int end = matrix.GetLength(1) - 1;

                while (start < end)
                {
                    (matrix[i, start], matrix[i, end]) = (matrix[i, end], matrix[i, start]);
                    start++;
                    end--;
                }
            }
            return matrix;
        }

    }
}
