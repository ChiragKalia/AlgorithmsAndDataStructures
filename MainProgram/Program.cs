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
            int n = Convert.ToInt32(Console.ReadLine());
            string[] calories_temp = Console.ReadLine().Split(' ');
            int[] calories = Array.ConvertAll(calories_temp, Int32.Parse);
            CalorieProblem problem = new CalorieProblem();
            long val = problem.calculateMinimumNumberOfMiles(calories, n);
            Console.WriteLine(val);
            Console.ReadLine();
        }

    }
}
