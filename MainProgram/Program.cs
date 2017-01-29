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
       
            /*Function to left rotate arr[] of siz n by d*/
            public string[] leftRotate(string[] arr, int d, int n)
            {
                int i, j, k;
                string temp;
                for (i = 0; i < gcd(d, n); i++)
                {
                    /* move i-th values of blocks */
                    temp = arr[i];
                    j = i;
                    while (1 != 0)
                    {
                        k = j + d;
                        if (k >= n)
                            k = k - n;
                        if (k == i)
                            break;
                        arr[j] = arr[k];
                        j = k;
                    }
                    arr[j] = temp;
                }
                return arr;
            }

            int gcd(int a, int b)
            {
                if (b == 0)
                    return a;
                else
                    return gcd(b, a % b);
            }
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
                /////////////////////////////////////////////////////////////////////////////
                string[] inputSizeandNOR = Console.ReadLine().Split(' ');
                int size = Convert.ToInt32(inputSizeandNOR[0]);
                int x = Convert.ToInt32(inputSizeandNOR[1]);
                string[] A = new string[size];
                A = Console.ReadLine().Split(' ');
                int n = A.Length; //self explanatory
                MainProgram.Program pro = new Program();
                A = pro.leftRotate(A, x, n);
                foreach (var item in A)
                {
                    Console.Write(item + " ");
                }
                Console.Read();
        }
    }
}
