using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProblems.Fibonacci_Series
{
    public class FibonacciSeriesUsingRecursion
    {
        static int[] F;
        public FibonacciSeriesUsingRecursion(int n)
        {
            F = new int[n];
            for (int i = 0; i < n; i++)
            {
                F[i] = -1;
            }
            F[0] = 0;
            F[1] = 1;
        }
        //<summary>
        // A function that returns sum of fibonacci series using recursion with memorization technique. 
        //</summary>
        //<param name="n">Number of elements in that series</param>
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            if (F[n] != -1)
            {
                return F[n];
            }
            F[n] = Fib(n - 1) + Fib(n - 2);
            return F[n];
        }
    }
    public class FibonacciSeries
    {
        static int a = 0;
        static int b = 1;
        static int[] GetFibonacciSequence(int max)
        {
            int[] fibonacciSequence = new int[10];
            for (int i = 0; i <= max - 1; i++)
            {
                if (i == 0)
                {
                    fibonacciSequence[i] = a;
                    fibonacciSequence[++i] = b;
                }
                else
                {
                    fibonacciSequence[i] = b;
                }
                int c = b;
                b = a + b;
                a = c;
            }
            return fibonacciSequence;
        }
        static uint GetNthNumberInFibonacciSequence(int n)
        {
            uint a = 0;
            uint b = 1;
            uint c = 1;

            for (uint i = 0; i < n; i++)
            {
                c = b + a;
                a = b;
                b = c;
            }
            return c;
        }
    }

}
