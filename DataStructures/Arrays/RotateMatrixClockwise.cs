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
        public void RotateMatrix(ref int[,] A, int n) // This method will rotate a matrix by 90degrees clockwise. //Params -1) Array 2) Size of matrix.
        {
            //Incomplete will work for only 2*2 matrix for now. //Will update for more.
            int last = n - 1;
            int totalNumberOfLevels = n/2;
            int level = 0;
            while(level<totalNumberOfLevels)
            {
                for (int i = level; i < last; i++)
                {
                    SwapVars.Swap(ref A[level, i], ref A[i, last]);
                    SwapVars.Swap(ref A[level, i], ref A[last, last-i+level]);
                    SwapVars.Swap(ref A[level, i], ref A[last - i + level, level]);
                    //PrintMatrix.Print2DMatrix(A, n);
                }
                ++level;
                --last;
            }
        }
    }
}
