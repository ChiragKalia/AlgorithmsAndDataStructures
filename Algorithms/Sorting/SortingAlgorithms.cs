using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SortingAlgorithms
    {
        public int[] InsertionSort(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }
            else
            {
                int key;
                int[] sorted = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    key = arr[i];
                    sorted[i] = key;
                    j = i - 1;
                    while (i > 0 && arr[i]> key)
                    {
                        arr[i + 1] = arr[i];
                        i = i - 1;
                    }
                    arr[i + 1] = key;
            }
            return arr;
        }
    }
}
}
