using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.DataStructures;
using MainProgram.DataStructuresTests;
using DataStructures.Arrays;

namespace Algorithms.MainProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Test Patterns

            //PatternsTests patternsTests = new PatternsTests();
            //patternsTests.TestTriangularPattern(5);
            //patternsTests.TestPrintMyNamesFirstCharacter(5);

            //Print Pyramid
            //patternsTests.TestPrintPyramid();

            //Test Arrays

            //ArraysTests arraysTests = new ArraysTests();

            //Test Array Reversal
            //arraysTests.TestReversedArrays(new int[5]{1,2,4,5,6});

            //Test Maximum Hour Glass Reversal
            //int[,] arr = new int[6, 6] { { 1, 1 ,1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 0, 9, 2, - 4, -4,0 }, { 0, 0, 0, -2, 0, 0 }, { 0, 0, -1, -2, -4, 0 } };
            //Console.WriteLine(" Maximum Sum"+arraysTests.TestMaximumHourGlassSum(arr));
            //Console.Read();

            //Test Algorithms

            AddTwoArrays add = new AddTwoArrays();

            int[] array = new int[] { 5, 1, 2, 6, 4, 10 };
            int[] array2 = new int[] { 45, 23, 7, 12, 25, 8 };
            //sortedArray.ReturnSortedArray(ref array);
            //int[] array2 = sortedArray.ReturnSortedArray(new int[] { 1, 2, 3, 4, 5, 6 });
            int [] output = add.ReturnSumOfTwoArrays(array, array2);
            Console.WriteLine(" Sorted Array is : ");
            foreach (int i in output)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
