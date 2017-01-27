using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.DataStructures;
using MainProgram.DataStructuresTests;
using DataStructures.Arrays;
using MainProgram.AlgorithmsTests;

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

            //AddTwoArrays add = new AddTwoArrays();

            //int[] array = new int[] { 5, 1, 2, 6, 4, 10 };
            //int[] array2 = new int[] { 45, 23, 7, 12, 25, 8 };
            //sortedArray.ReturnSortedArray(ref array);
            //int[] array2 = sortedArray.ReturnSortedArray(new int[] { 1, 2, 3, 4, 5, 6 });
            //int [] output = add.ReturnSumOfTwoArrays(array, array2);
            //Console.WriteLine(" Sorted Array is : ");
            //foreach (int i in output)
            //{
            //    Console.Write(i + " ");
            //}
            //MergeSortTester tester = new MergeSortTester();
            //InsertionSortTester tester = new InsertionSortTester();
            //int[] arr = new int[8] { 2,4,3,6,1,4,7,9};
            //tester.InsertionSortTest(arr);
            //tester.TestMergeSort(arr);
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //string[] ret_arr = new string[n];
            //int iterator = 0;
            //for (int i = n; i > 0; i--)
            //{
            //    ret_arr[iterator] = arr_temp[i];
            //    iterator = iterator + 1;
            //}
            //foreach (string i in ret_arr)
            //{
            //    Console.Write(i + "");
            //}
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            Console.Read();
        }
    }
}
