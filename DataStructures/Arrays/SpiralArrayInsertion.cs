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
        //          [8 9 4]
        //           [7 6 5]
        public void InsertValuesSpirally(ref int[,] A, int n)
        {
            int rowsProcessed = 0;
            int columnsProcessed = 0;
            int nrt = n / 2;
            int nOrig = n;
            int LSI = 0, LEI = n;
            int TSI = 0, TEI = n;
            int count = 1;
            while (rowsProcessed < nrt)
            {
                for (int i = TSI; i < TEI; i++)
                {
                    if (i == TSI)
                    {
                        for (int j = LSI; j < LEI; j++) // Will implement row by row from left to rights* * * * * * * *
                        {
                            A[i, j] = count++;
                        }
                    }
                    if (rowsProcessed > 0)
                    {
                        PrintMatrix.Print2DMatrix(A, (int)Math.Sqrt(A.Length));
                    }
                    if ((TEI - TSI) > 1)
                    {

                        if (i == TSI)
                        {
                            i++;
                        }
                        TSI++;
                        //TEI--;
                        LSI = n - 1;
                        for (int j = LSI; j < LEI; j++) // Will implement up down from right side
                        {
                            A[i, j] = count++;
                        }
                    }
                    if(rowsProcessed>0)
                    {
                        PrintMatrix.Print2DMatrix(A, (int)Math.Sqrt(A.Length));
                    }
                    if (i==TEI-1)
                    {
                        LSI = n - 2;
                        LEI = columnsProcessed;
                        for (int j = LSI; j >= columnsProcessed; j--) // Will implement row by row from right to left
                        {
                            A[i, j] = count++;
                        }
                        rowsProcessed++;
                        if (rowsProcessed > 0)
                        {
                            PrintMatrix.Print2DMatrix(A, (int)Math.Sqrt(A.Length));
                        }
                    }
                }
                TSI = 0 + rowsProcessed;
                TEI = nOrig - rowsProcessed;
                if(TEI-TSI == 1)
                {
                    TEI++;
                }
                LSI = columnsProcessed;
                LEI = LSI + 1;
                for (int i = TEI-1; i >= TSI; i--)
                {
                    for (int j = LSI; j < LEI; j++)
                    {
                        A[i, j] = count++;
                    }
                }
                columnsProcessed++;
                n--;
                LSI = columnsProcessed;
                LEI = n;
                Console.WriteLine();
                Console.WriteLine();
                PrintMatrix.Print2DMatrix(A, (int)Math.Sqrt(A.Length));
            }
        }
    }
}
