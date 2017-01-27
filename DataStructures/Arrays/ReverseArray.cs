using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    class ReverseArray
    {
        public string[] ReverseAnArray(string[] A, int n)
        {
            string[] ret_arr = new string[n];
            int iterator = 0;
            for (int i = n; i > 0; i++)
            {
                ret_arr[iterator] = A[i];
            }
            return ret_arr;
        }
    }
}
