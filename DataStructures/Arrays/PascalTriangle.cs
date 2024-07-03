using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class PascalTriangle
    {
        /*
        1
        1 1
        1 2 1
        1 3 3 1
        1 4 6 4 1
        1 5 10 10 5 1

        Observation - as you can see every row begins with 1 and the next element is row number - 1 ( 3rd row second element is 2), 4th row second element is 3

        For more details: https://www.youtube.com/watch?v=bR7mQgwQ_o8
        */

        public static long PrintElement(int row, int col)
        {
            long element = 1;
            for (int i = 0; i < col; i++)
            {
                element *= (row - i);
                element /= (i + 1);
            }
            return element;
        }
        public static void PrintRow(int row) //O(row*col) complexity near about n*n) which is bad
        {
            for (int i = 0; i < row; i++)
            {
                Console.Write(PrintElement(row - 1, i) + " ");
            }
        }
        public static long[] GenerateRow(int row) //O(n) complexity
        {
            long res = 1;
            long[] result = new long[row];
            result[0] = res;
            Console.Write(res + " ");
            for (int i = 1; i < row; i++) //Every row starts from 1 as the 0th element so we skipped the first element of the row
            {
                res *= (row - i);
                res /= i;
                result[i] = res;
                Console.Write(res + " ");
            }
            Console.WriteLine();
            return result;
        }
        public static void GeneratePascalTriangle(int totalNumberofRows) //O(n*n) complexity to print the whole tree
        {
            long[][] retArr = new long[totalNumberofRows + 1][];
            for (int i = 1; i <= totalNumberofRows; i++)
            {
                retArr[i] = GenerateRow(i);
            }

        }
    }
}