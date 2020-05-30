using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class MoveZeroesToEndOfArray
    {
        public static void MoveZeroesToEndArray(int[] nums)
        {
            int n = nums.Length;
            // Count of non-zero elements 
            int count = 0;

            // Traverse the array. If element encountered is 
            // non-zero, then replace the element  
            // at index â..countâ.. with this element 
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                    // here count is incremented 
                    nums[count++] = nums[i];
            }


            // Now all non-zero elements have been shifted to 
            // front and â..countâ.. is set as index of first 0. 
            // Make all elements 0 from count to end. 
            while (count < n)
                nums[count++] = 0;
        }
    }
}
