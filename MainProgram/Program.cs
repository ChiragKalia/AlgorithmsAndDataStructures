using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.DataStructures;
using DataStructures.Arrays;
using DataStructures.LinkedLists;
using AbstractProblems.MarcsCakewalk;
using Algorithms.Searching;
using Algorithms.BitManipulation;
using AbstractProblems.Fibonacci_Series;
using DataStructures.Trees;
using static DataStructures.Trees.BinarySearchTree;
using Algorithms.Sorting;
using DataStructures.Helpers;
//using DataStructures.LinkedLists;

namespace Algorithms.MainProgram
{
    public class Program
    {
        static void Main(string[] args)
        {

            int n = 4;
            int[,] A = new int[n,n];
            //for (int i =0; i< n; i++)
            //{
            //    string[] sArr = Console.ReadLine().Split(' ');
            //    int[] arr = Array.ConvertAll(sArr, Int32.Parse);
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        A[i,j] = arr[j];
            //    }
            //}
            //CommonElements elements = new CommonElements();
            //int[] output = elements.GetCommonElementsUsingDictionary(A,n);
            //foreach (var item in output)
            //{
            //    Console.WriteLine(" " + item);
            //}
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = count++;
                }
            }
            Console.WriteLine(" Original Matrix: ");
            PrintMatrix.Print2DMatrix(A, n);
            Console.WriteLine(" Rotated Matrix: ");
            RotateMatrixClockwise rotate = new RotateMatrixClockwise();
            rotate.RotateMatrix(ref A, n);
            PrintMatrix.Print2DMatrix(A, n);

            //Sort Binary Array
            //BinaryArraySort sortBinary = new BinaryArraySort();
            //Console.WriteLine(" Original Matrix: ");
            //PrintMatrix.Print1DMatrix(A, n);
            //Console.WriteLine();
            //A = sortBinary.sortBinaryArray(A, n);
            //Console.WriteLine(" Sorted Matrix: ");
            //PrintMatrix.Print1DMatrix(A, n);
            Console.ReadLine();
        }

    }
}
