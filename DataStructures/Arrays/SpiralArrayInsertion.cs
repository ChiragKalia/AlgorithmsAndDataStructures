using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class SpiralArrayInsertion
    {
        // This program inserts values in a n*n array spherically. e.g if n = 3
        //Output - [1 2 3]
        //         [8 9 4]
        //         [7 6 5]
        //Problem Statement - https://leetcode.com/problems/spiral-matrix-ii
        //Solution - https://www.youtube.com/watch?v=NO1zLdOwgR0
        public static int[][] GenerateSpiralMatrix(int n)
        {
            int[][] matrix = new int[n][]; //As per the leetcode problem I've used Jagged Array otherwise it's better if we have 2d array as we won't have to instanciate it.
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }
            int rowBegin = 0, rowEnd = n - 1;
            int columnBegin = 0, columnEnd = n - 1;
            int counter = 1;
            while (rowBegin <= rowEnd && columnBegin <= columnEnd)
            {
                for (int i = columnBegin; i <= columnEnd; i++)
                {
                    matrix[rowBegin][i] = counter++;
                }
                rowBegin++;

                for (int i = rowBegin; i <= rowEnd; i++)
                {
                    matrix[i][columnEnd] = counter++;
                }
                columnEnd--;

                if (rowBegin <= rowEnd)
                {
                    for (int i = columnEnd; i >= columnBegin; i--)
                    {
                        matrix[rowEnd][i] = counter++;
                    }
                    rowEnd--;
                }
                if (columnEnd >= columnBegin)
                {
                    for (int i = rowEnd; i >= rowBegin; i--)
                    {
                        matrix[i][columnBegin] = counter++;
                    }
                    columnBegin++;
                }
            }
            return matrix;
        }
    }
}
