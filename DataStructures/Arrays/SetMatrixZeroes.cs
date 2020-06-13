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
        //https://www.interviewbit.com/problems/set-matrix-zeros/
        public static int[][] SetMatrixZeroesInRowsAndColumns(int[][] matrix)
        {
            if (matrix.Length == 0) return matrix;
            List<KeyValuePair<int, int>> map = new List<KeyValuePair<int, int>>(); // To store the row and column of 0 values.
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        var kvPair = new KeyValuePair<int, int>(i, j);
                        map.Add(kvPair);
                    }
                }
            }
            if (map.Count > 0)
            {
                foreach (KeyValuePair<int, int> index in map)
                {
                    for (int i = 0; i < matrix[index.Key].Length; i++)
                    {
                        matrix[index.Key][i] = 0;
                    }
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        matrix[i][index.Value] = 0;
                    }
                }
            }
            return matrix;
        }

    }
}
