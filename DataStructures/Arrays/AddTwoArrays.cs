using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class AddTwoArrays
    {
        SortedArray sortedArray;
        
        public AddTwoArrays()
        {
            sortedArray = new SortedArray();
        }

        public int[] ReturnSumOfTwoArrays(int[] arr1, int[] arr2)
        {
            int[] collectiveArray = new int[arr1.Length+arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                collectiveArray[i] = arr1[i];
            }
            int j = 0;
            for (int i = arr2.Length; i < collectiveArray.Length; i++)
            {
                collectiveArray[i] = arr2[j];
                j++;
            }
            sortedArray.ReturnSortedArray(ref collectiveArray);
            return collectiveArray; 
        }
    }
}
