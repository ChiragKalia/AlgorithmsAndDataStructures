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
            int LSI = 0, TSI = 0;
            int LEI = n, TEI = n;
            int count = 1;
            int rowsProcessed = 0;
            for (int i = TSI; i < TEI; i++)
            {
                if(i== TSI)
                {
                    for (int j = LSI; j < LEI; j++)
                    {
                        A[i, j] = count++;
                    } //Complete for first row.
                    
                    if (n > 2 && i == 0)
                    {
                        LSI = n - 1;
                    }
                    else if (n == 2)
                    {
                        LSI = n - 1;
                    }
                }
                if(i>TSI && i!=n-1)
                {
                    for (int j = LSI; j < LEI; j++)
                    {
                        A[i, j] = count++;
                    }
                }

                if (i==(n-1))
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        A[n - 1, j] = count++;
                    } // For last row.
                    LSI = 0; LEI = 1;
                    for (int j = LSI; j < LEI; j++)
                    {
                        A[i, j] = count++;
                    }
                    PrintMatrix.Print2DMatrix(A, n);
                    --n;
                    ++rowsProcessed;
                    i = rowsProcessed -1;
                    ++TSI;
                    --TEI;
                    LSI = 0+ rowsProcessed;
                    --LEI;
                    
                }
            }


            //Console.WriteLine(" ");
            //if (n>2)
            //{
            //    for (int i = n - 1; i >= 0; i--)
            //    {
            //        A[n - 1, i] = count++;
            //    }
            //    //PrintMatrix.Print2DMatrix(A, n);
            //    LSI = 0; LEI = 1;
            //    TSI = 0; TEI = n - 2;
            //    for (int i = TEI; i > TSI; i--)
            //    {
            //        if (i == 1)
            //        {
            //            LEI = n - 1;
            //        }
            //        for (int j = LSI; j < LEI; j++)
            //        {
            //            A[i, j] = count++;
            //        }
            //    }
            //    LSI = n - 3; LEI = n - 2;
            //    TSI = 2; TEI = n - 1;
            //    for (int i = TSI; i < TEI; i++)
            //    {
            //        if (i == n - 2)
            //        {
            //            LSI = 0;
            //        }
            //        for (int j = LEI; j > LSI; j--)
            //        {
            //            A[i, j] = count++;
            //        }
            //    }
            //}
            //else if(n==2)
            //{
            //    A[1, 0] = count++;
            //}
        }
    }
}
