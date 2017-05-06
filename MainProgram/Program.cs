using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.DataStructures;
using MainProgram.DataStructuresTests;
using DataStructures.Arrays;
using DataStructures.LinkedLists;
using MainProgram.AlgorithmsTests;
using AbstractProblems.MarcsCakewalk;
using Algorithms.Searching;
using Algorithms.BitManipulation;
using AbstractProblems.Fibonacci_Series;
using DataStructures.Trees;
using static DataStructures.Trees.BinarySearchTree;
using Algorithms.Sorting;
//using DataStructures.LinkedLists;

namespace Algorithms.MainProgram
{
    public class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n, n];
            for (int i =0; i< n; i++)
            {
                string[] sArr = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(sArr, Int32.Parse);
                for (int j = 0; j < arr.Length; j++)
                {
                    A[i,j] = arr[j];
                }
            }
            CommonElements elements = new CommonElements();
            int[] output = elements.GetCommonElements(A,n);
            foreach (var item in output)
            {
                Console.WriteLine(" " + item);
            }
            Console.ReadLine();
        }

    }
}
