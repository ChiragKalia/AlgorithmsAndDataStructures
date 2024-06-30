using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class SetMatrixZeroes
    {
        //When we encounter a zero in matrix, We'll set the entire row and column of that index to zero
        //https://takeuforward.org/interviews/strivers-sde-sheet-top-coding-interview-problems
        //https://www.youtube.com/watch?v=N0MgLvceX7M
        public static int[,] SetMatrixZero(int[,] matrix, int n, int m)
        {
            int col0 = 1;
            //int[] row[n] = matrix[][n]
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        //mark the ith row
                        matrix[i, 0] = 0;
                        //mark the jth col
                        if (j != 0)
                        {
                            matrix[0, j] = 0;
                        }
                        else
                        {
                            col0 = 0;
                        }
                    }
                }
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        if (matrix[i, 0] == 0 || matrix[j, 0] == 0)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }
            }

            if (matrix[0, 0] == 0)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[0, j] = 0;
                }
            }
            if (col0 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    matrix[i, 0] = 0;
                }
            }
            return matrix;
        }

    }
}
