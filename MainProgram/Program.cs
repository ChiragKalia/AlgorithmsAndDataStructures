using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.DataStructures;
using MainProgram.DataStructuresTests;
using DataStructures.Arrays;
using MainProgram.AlgorithmsTests;
using AbstractProblems.MarcsCakewalk;
//using DataStructures.LinkedLists;

namespace Algorithms.MainProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LinkedList list = new LinkedList();
            //list.AddSorted(9);
            //list.AddSorted(5);
            //list.AddSorted(7);
            //list.AddSorted(11);
            //list.Print();
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] calories_temp = Console.ReadLine().Split(' ');
            //int[] calories = Array.ConvertAll(calories_temp, Int32.Parse);
            //CalorieProblem problem = new CalorieProblem();
            //long val = problem.calculateMinimumNumberOfMiles(calories, n);
            //Console.WriteLine(val);
            int length = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                string[] array = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(array, Int32.Parse);
                for (int j = 0; j < length; j++)
                {
                    A[i, j] = arr[j];
                }
            }
            Sort2DArray sorter = new Sort2DArray();
            sorter.sort2DArray(ref A, length);
            Console.WriteLine("Printing Sorted Array");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(A[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }

    }
}
