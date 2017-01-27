using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class MergeSorter
    {
        public void HalveTheArray(int[] a)
        {
            int n = a.Length;
            if (a.Length / 2 == 1)
            {
                return;
            }
            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n-mid];
            for (int i = 0; i < mid; i++)
            {
                left[i] = a[i];
            }
            for(int j=n-mid; j<n; j++)
            {
                right[j-mid] = a[j];
            }
            HalveTheArray(left); //Recursive call to further divide the array into two parts
            HalveTheArray(right); //Recursive call to further divide the array into two parts
            Merge(left, right, a); //Pass the bisected array to merge method
        }
        public void Merge(int[] L, int[] R,int[] A)
        {
            int leftLength = L.Length;
            int rightLength = R.Length;
            int arrayLength = A.Length;
            int i = 0, j = 0, k = 0; //Iterators
            while (i < leftLength && j < rightLength)
            {
                if (L[i] < R[j]) //Check which one's lower number
                {
                    A[k] = L[i];
                    i++; 
                }
                if (R[j] < L[i])
                {
                    A[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < leftLength)
            {
                A[k] = L[i];
                i++;
                k++; 
            }
            while (j < rightLength)
            {
                A[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
