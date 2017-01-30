using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class AlgorithmsCrush
    {
        public int GetHighestValueFromArray(int N, int M, int[,] A)
        {
            int[] result = new int[N];
            for (int i = 0; i < M; i++)
            {
                int startIndex = A[i,0] - 1;
                int endIndex = A[i, 1] - 1;
                int numberToBeAdded = A[i, 2];
                for (int j = startIndex; j < endIndex; j++)
                {
                    result[j] += numberToBeAdded;
                }
            }
            int maxValue = result[0];
            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] > maxValue)
                {
                    maxValue = result[i];
                }
            }
            return maxValue;
            //string[] NM = Console.ReadLine().Split(' '); //Get length of array and operations to be performed.
            //int N = Convert.ToInt32(NM[0]);
            //int M = Convert.ToInt32(NM[1]);
            //int[,] opArray = new int[M, 3];
            //for (int i = 0; i < M; i++)
            //{
            //    string[] arr = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < 3; j++)
            //    {
            //        opArray[i, j] = Convert.ToInt32(arr[j]);
            //    }
            //}
            //int[] result = new int[N];
            //for (int i = 0; i < M; i++)
            //{
            //    int startIndex = opArray[i, 0] - 1;
            //    int endIndex = opArray[i, 1] - 1;
            //    int numberToBeAdded = opArray[i, 2];
            //    for (int j = startIndex; j < endIndex; j++)
            //    {
            //        result[j] += numberToBeAdded;
            //    }
            //}
            //int maxValue = result[0];
            //for (int i = 0; i < result.Length; i++)
            //{
            //    if (result[i] > maxValue)
            //    {
            //        maxValue = result[i];
            //    }
            //}
            //Console.WriteLine(maxValue);
        }
    }
}
