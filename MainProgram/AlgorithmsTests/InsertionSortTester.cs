using System;
using Algorithms.Sorting;

namespace MainProgram.AlgorithmsTests
{
    public class InsertionSortTester
    {



        InsertionSorter sorter;
        public InsertionSortTester()
        {
            sorter = new InsertionSorter();
        }
        public void InsertionSortTest(int[] array)
        {
            int[] output = sorter.InsertionSort(array, array.Length);
            Console.WriteLine("Output : ");
            foreach (int i in output)
            {
                Console.Write(i);
            }
        }
    }
}
