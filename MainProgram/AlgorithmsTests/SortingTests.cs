using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.AlgorithmsTests
{
    class SortingTests
    {
        public int[] TestInsertionSort(int [] arr)
        {
            SortingAlgorithms sorting = new SortingAlgorithms();
            sorting.InsertionSort(arr);
            return arr;
        }
    }
}
