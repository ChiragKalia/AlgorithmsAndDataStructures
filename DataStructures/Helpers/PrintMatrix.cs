using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Helpers
{
    public class PrintMatrix
    {
        public void Print2DMatrix(int[,] A, int n)
        {
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }  
        }
    }
}
