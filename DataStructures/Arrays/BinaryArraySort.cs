using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class BinaryArraySort
    {
        public int[] sortBinaryArray(int[] A, int n)
        {
            //My Method //Fail
            //int mid = (n - 1) / 2;
            //for (int i = 0; i < n; i++)
            //{
            //    int currElem = A[i];
            //    if (A[i] == 0 &&  i > mid)  // If 0 found at location greater than mid then swap else do nothing
            //    {
            //        SwapVars.Swap(ref A[i], ref A[i - mid]);
            //    }
            //    else if (A[i] == 1 && i < mid)  // If 1 found at location less than mid then swap else do nothing
            //    {
            //        SwapVars.Swap(ref A[i], ref A[i + mid]);
            //    }
            //}

            //Second Method //Also Fail
            // int begin = 0;
            // int end = begin + (n - 1);
            // while(begin<end)
            // {
            //     if (A[begin] == 0)
            //         begin++;
            //     else if (A[end] == 1)
            //         end--;
            //     else
            //         A[begin] = 0;
            //         A[end] = 1;
            //}

            //Third Method: Pass
            int left = 0;
            int right = n - 1;
            while(left<right)
            {
                while(A[left] ==0 && left<right)
                {
                    left++;
                }
                while (A[right] == 1 && left<right)
                {
                    right--;
                }
                if(left<right)
                {
                    A[left] = 0;
                    A[right] = 1;
                    left++;
                    right--;
                }
            }
            return A;
        }
    }
}
