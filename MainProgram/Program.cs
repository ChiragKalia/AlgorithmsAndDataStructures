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
//using DataStructures.LinkedLists;

namespace Algorithms.MainProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddToEnd(9);
            list.AddToEnd(5);
            list.AddToEnd(7);
            list.AddToEnd(11);
            list.print();
            
            //int length = Convert.ToInt32(Console.ReadLine());
            //int[,] A = new int[length, length];
            //for (int i = 0; i < length; i++)
            //{
            //    string[] array = Console.ReadLine().Split(' ');
            //    int[] arr = Array.ConvertAll(array, Int32.Parse);
            //    for (int j = 0; j < length; j++)
            //    {
            //        A[i, j] = arr[j];
            //    }
            //}
            //Sort2DArray sorter = new Sort2DArray();
            //sorter.sort2DArray(ref A, length);
            //Console.WriteLine("Printing Sorted Array");
            //for (int i = 0; i < length; i++)
            //{
            //    for (int j = 0; j < length; j++)
            //    {
            //        Console.Write(A[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadLine();

        }

    }
}
