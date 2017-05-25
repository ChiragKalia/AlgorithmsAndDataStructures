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
            if (n % 2 == 1)
            {
                nrt++;
            }
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
                    if (i == TEI - 1)
                    {
                        LSI = n - 2;
                        LEI = columnsProcessed;
                        for (int j = LSI; j >= columnsProcessed; j--) // Will implement row by row from right to left
                        {
                            A[i, j] = count++;
                        }
                        rowsProcessed++;
                    }
                }
                TSI = 0 + rowsProcessed;
                TEI = nOrig - rowsProcessed;
                //if(TEI-TSI == 1)
                //{
                //    TEI++;
                //}
                LSI = columnsProcessed;
                LEI = LSI + 1;
                for (int i = TEI - 1; i >= TSI; i--)
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
            }
        }
        public List<List<int>> GenerateMatrix(int A)
        {
            List<List<int>> mList = new List<List<int>>();
            int[,] arr = new int[A, A];
            int rowsProcessed = 0;
            int columnsProcessed = 0;
            int nrt = A / 2;
            if (A % 2 == 1)
            {
                nrt++;
            }
            int nOrig = A;
            int LSI = 0, LEI = A;
            int TSI = 0, TEI = A;
            int count = 1;
            while (rowsProcessed < nrt)
            {
                for (int i = TSI; i < TEI; i++)
                {
                    if (i == TSI)
                    {
                        for (int j = LSI; j < LEI; j++) // Will implement row by row from left to rights* * * * * * * *
                        {
                            arr[i, j] = count++;
                        }
                    }
                    if ((TEI - TSI) > 1)
                    {

                        if (i == TSI)
                        {
                            i++;
                        }
                        TSI++;
                        //TEI--;
                        LSI = A - 1;
                        for (int j = LSI; j < LEI; j++) // Will implement up down from right side
                        {
                            arr[i, j] = count++;
                        }
                    }
                    if (i == TEI - 1)
                    {
                        LSI = A - 2;
                        LEI = columnsProcessed;
                        for (int j = LSI; j >= columnsProcessed; j--) // Will implement row by row from right to left
                        {
                            arr[i, j] = count++;
                        }
                        rowsProcessed++;
                    }
                }
                TSI = 0 + rowsProcessed;
                TEI = nOrig - rowsProcessed;
                //if(TEI-TSI == 1)
                //{
                //    TEI++;
                //}
                LSI = columnsProcessed;
                LEI = LSI + 1;
                for (int i = TEI - 1; i >= TSI; i--)
                {
                    for (int j = LSI; j < LEI; j++)
                    {
                        arr[i, j] = count++;
                    }
                }
                columnsProcessed++;
                A--;
                LSI = columnsProcessed;
                LEI = A;
            }
            for (int i = 0; i < nOrig; i++)
            {
                List<int> subList = new List<int>(nOrig);
                for (int j = 0; j < nOrig; j++)
                {
                    subList.Add(arr[i, j]);
                }
                mList.Add(subList);
            }
            return mList;
        }
    }
}
