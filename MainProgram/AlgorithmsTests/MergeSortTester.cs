using Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.AlgorithmsTests
{
    class MergeSortTester
    {
        MergeSorter m;
        public MergeSortTester()
        {
            m = new MergeSorter();
        }
        public void TestMergeSort(int[] array)
        {
            m.HalveTheArray(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
