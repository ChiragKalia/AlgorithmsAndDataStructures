using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class RepetitiveElementsArray
    {
        //This function will print repetitive elements in array
        public void PrintRepetitiveElementsInArray(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int val = Math.Abs(A[i]);
                int arrVal = A[Math.Abs(A[i])];
                if (arrVal >= 0)
                {
                    A[Math.Abs(A[i])] = -A[Math.Abs(A[i])];
                }
                    
                {
                    Console.WriteLine(Math.Abs(A[i]));
                }
            }
        }
    }
}
