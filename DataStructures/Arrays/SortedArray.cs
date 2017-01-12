using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class SortedArray
    {
        public void ReturnSortedArray(ref int[] arr1)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        arr1[i] = arr1[i] + arr1[j];
                        arr1[j] = arr1[i] - arr1[j];
                        arr1[i] = arr1[i] - arr1[j];
                    }
                }
            }
            
        }
    }
}
