using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sorting;

namespace MainProgram.AlgorithmsTests.Sorting
{
    class SortingAlgorithmTests
    {
        static void Main()
        {
            TestBedArrayClass nums = new TestBedArrayClass(49);
            for (int i = 0; i <= 49; i++)
                nums.Insert(i);
            nums.DisplayElements();
        }
    }
}
