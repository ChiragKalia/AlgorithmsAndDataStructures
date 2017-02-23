using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class Sort2DArray
    {
        //<summary>
        // A function that sorts a two dimensional array of size n*n
        //</summary>
        //<param name="length"> Length of array(row*columns)</param>
        //<param name="A">Array to be Sorted</param>
        //I have to make it type agnostic //Maybe Later
        //It's not an ideal program currently, Having a time complexity of O(N3(cube)). But I'll tweak it later.
        public int[,] sort2DArray(ref int[,] A, int length)
        {
            for (int i = 0; i < length; i++)
            {
                int counter = length;
                while(counter>0)
                {
                    for (int j = 0; j < length - 1; j++)
                    {
                        int numberToBeCompared = A[i, j];
                        if (A[i, j] > A[i, j + 1])
                        {
                            int temp = A[i, j + 1];
                            A[i, j + 1] = numberToBeCompared;
                            A[i, j] = temp;
                        }
                    }
                    counter--;
                }
             }
            return A;
        }

    }
}
