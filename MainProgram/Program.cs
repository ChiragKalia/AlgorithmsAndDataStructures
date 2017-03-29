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
//using DataStructures.LinkedLists;

namespace Algorithms.MainProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LinkedList list = new LinkedList();
            //list.AddToEnd(9);
            //list.AddToEnd(5);
            //list.AddToEnd(7);
            //list.AddToEnd(11);
            //list.Print();

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

            //BinarySearching searching = new BinarySearching();
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr = Console.ReadLine().Split(' '); //Get the sorted array from user seperated by space
            //int[] A = Array.ConvertAll(arr, Int32.Parse);
            //int x = Convert.ToInt32(Console.ReadLine());
            //int index = searching.GetElementIndex(A, n, x);
            //Console.WriteLine("Element Index is " + index);
            //Fibonacci
            //int n = 10;
            //FibonacciSeriesUsingRecursion fibonacci = new FibonacciSeriesUsingRecursion(n+1);
            //Console.WriteLine("Output: "+fibonacci.Fib(n));
            BinarySearchTree bst = new BinarySearchTree();

            BSTNode root = null;
            root = bst.Insert(root, 15); root = bst.Insert(root, 10); root = bst.Insert(root, 20);
            root = bst.Insert(root, 25); root = bst.Insert(root, 8); root = bst.Insert(root, 12);
            Console.WriteLine("Enter Number To Be Searched: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(bst.Search(root,number) == true)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            Console.WriteLine("Do you want to delete a node? If yes then type the node data");
            int numberToBeDeleted = Convert.ToInt32(Console.ReadLine());
            root = bst.Delete(root, numberToBeDeleted);
            if (bst.Search(root, numberToBeDeleted) == true)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            Console.ReadLine();

        }

    }
}
