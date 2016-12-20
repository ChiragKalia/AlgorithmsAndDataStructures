using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Arrays
{
    public static class Arrays
    {
        //This Method Finds The Reverse of a one dimensional array
        public static int[] ReverseArray(int[] arr)
        {
            int[] rev = new int[arr.Length];
            if (arr.Length == 1)
            {
                return arr;
            }
            else
            {
                for (int i = arr.Length; i > 0; i--)
                {
                    int index = arr.Length - i;
                    rev[index] = arr[i - 1];
                }
            }
            return rev;
        }
        public static int GetMaximumHourGlassSum(int[,] arr)
        {
                int rowLength = arr.GetLength(0);
                int columnLength = arr.GetLength(1);
                int maxSum = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        int sum = arr[i, j] + arr[i, j + 1] + arr[i, j + 2]
                                                + arr[i + 1, j + 1]
                                + arr[i + 2, j] + arr[i + 2, j + 1] + arr[i + 2, j + 2];
                        if (maxSum < sum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            return maxSum;
        }
    }
}
