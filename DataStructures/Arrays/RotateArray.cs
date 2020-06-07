using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class RotateArray
    {
        public static void LeftRotateArray(int[] arr, int pivot, int n)
        {
            for (int i = 0; i < pivot; i++)
            {
                int swap = arr[0];
                for (int j = 0; j < n - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[n - 1] = swap;
            }
        }
    }
}
