using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class RotateMatrixClockwise
    {
        SwapVars swapClass;
        public RotateMatrixClockwise()
        {
            swapClass = new SwapVars();
        }
        public void RotateMatrix(ref int[,] A, int n) // This method will rotate a matrix by 90degrees clockwise. //Params -1) Array 2) Size of matrix.
        {
            //Incomplete will work for only 2*2 matrix for now.
            int last = n - 1;
            for(int i=0; i<last; i++)
            {
                swapClass.Swap(ref A[i,i], ref A[i,last]);
                swapClass.Swap(ref A[i, i], ref A[last, last]);
                swapClass.Swap(ref A[i, i], ref A[last, i]);
            }
        }
    }
}
