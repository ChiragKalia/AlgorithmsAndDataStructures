using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.DataStructures;
using MainProgram.DataStructuresTests;
using DataStructures.Arrays;
using MainProgram.AlgorithmsTests;
using Algorithms.Warmup;

namespace Algorithms.MainProgram
{
    public class Program
    {
            static void Main(string[] args)
            {
            int length = Convert.ToInt32(Console.ReadLine());
            string[] arr = Console.ReadLine().ToString().Split(' ');
            int[] A = Array.ConvertAll(arr, Int32.Parse);
            PlusMinus pm = new PlusMinus();
            string[] output = pm.CountFractions(length, A);
            foreach(string i in output)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }

    }
}
