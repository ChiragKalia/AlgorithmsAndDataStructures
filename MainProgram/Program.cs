using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.DataStructures;
using MainProgram.DataStructuresTests;

namespace Algorithms.MainProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Test Patterns

            PatternsTests patternsTests = new PatternsTests();
            //patternsTests.TestTriangularPattern(5);
            //patternsTests.TestPrintMyNamesFirstCharacter(5);

            //Print Pyramid
            patternsTests.TestPrintPyramid();

            //Test Arrays

            //ArraysTests arraysTests = new ArraysTests();

            //Test Array Reversal
            //arraysTests.TestReversedArrays(new int[5]{1,2,4,5,6});

            //Test Maximum Hour Glass Reversal
            //int[,] arr = new int[6, 6] { { 1, 1 ,1, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 }, { 1, 1, 1, 0, 0, 0 }, { 0, 9, 2, - 4, -4,0 }, { 0, 0, 0, -2, 0, 0 }, { 0, 0, -1, -2, -4, 0 } };
            //Console.WriteLine(" Maximum Sum"+arraysTests.TestMaximumHourGlassSum(arr));
            //Console.Read();

        }
    }
}
