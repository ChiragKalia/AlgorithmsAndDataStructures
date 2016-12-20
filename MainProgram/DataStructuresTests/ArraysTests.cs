using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.DataStructures.Arrays;

namespace MainProgram.DataStructuresTests
{
    class ArraysTests
    {
        public void TestReversedArrays(int[] arr)
        {
            arr = Arrays.ReverseArray(arr);
            Console.Write("Reversed Array: ");
            string output = string.Empty;
            foreach (var j in arr)
            {
                output += j + " ";
            }
            Console.WriteLine(output);
            Console.Read();
        }
        public int TestMaximumHourGlassSum(int[,] arr)
        {
            return Arrays.GetMaximumHourGlassSum(arr);
        }

    }
}
