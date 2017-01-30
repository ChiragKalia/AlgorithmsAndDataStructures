using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class SparseArray
    {
        public int[] calculateSparseArray(int n, int q, string[] A, string[] QA)
        {
            int[] result = new int[q];
            for (int i = 0; i < q; i++)
            {
                int occurence = 0;
                for (int j = 0; j < n; j++)
                {
                    if (A[j] == QA[i])
                    {
                        occurence++;
                    }
                }
                result[i] = occurence;
            }
            return result;
        }
    }
}
