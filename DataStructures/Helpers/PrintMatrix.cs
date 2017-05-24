using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Helpers
{
    public static class PrintMatrix
    {
        public static void Print2DMatrix(int[,] A, int n)
        {
            Console.Clear();
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if(A[i,j] <10)
                    {
                        Console.Write(A[i, j] + "   ");
                    }
                    else if(A[i,j]<100)
                    {
                        Console.Write(A[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(A[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }  
        }
        public static void Print1DMatrix(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
            }
        }

    }
}
