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
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] A = new string[n];
            //for (int i = 0; i<n; i++)
            //{
            //    A[i] = Console.ReadLine();
            //}
            //int q= Convert.ToInt32(Console.ReadLine());
            //string[] QA = new string[q];
            //for (int i = 0; i < q; i++)
            //{
            //    QA[i] = Console.ReadLine();
            //}
            //SparseArray array = new SparseArray();
            //int[] arr = array.calculateSparseArray(n, q, A, QA);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            
            string[] NM = Console.ReadLine().Split(' '); //Get length of array and operations to be performa
            int N = Convert.ToInt32(NM[0]);
            int M = Convert.ToInt32(NM[1]);
            int[,] opArray = new int[M, 3];
            for (int i = 0; i < M; i++)
            {
               string[] arr= Console.ReadLine().Split(' ');
                for(int j=0; j<3; j++)
                {
                    opArray[i, j] = Convert.ToInt32(arr[j]);
                } 
            }
            AlgorithmsCrush crush = new AlgorithmsCrush();
            int result = crush.GetHighestValueFromArray(N, M, opArray);
            Console.WriteLine(result);
            Console.Read();
        }

    }
}
