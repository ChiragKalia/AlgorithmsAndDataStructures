using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class SwapMinMax
    {
        public static void SwapMinAndMaxElement(int[] arr)
        {
            int minValue = arr[0];
            int maxValue = arr[0];
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    maxIndex = i;
                }
                if (arr[i] < minValue)
                {
                    minIndex = i;
                    minValue = arr[i];
                }
            }
            int tempVar = minValue;
            arr[minIndex] = maxValue;
            arr[maxIndex] = tempVar;
        }
    }
}
