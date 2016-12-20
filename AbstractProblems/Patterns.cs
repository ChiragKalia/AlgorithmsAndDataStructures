using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Algorithms.AbstractProblems
{
    public static class Patterns
    {
        public static void PrintStar(int number)
        {
            //This will print a star
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
        public static void PrintMyName(int number)
        {
            string s = null;
            string p = s?.ToString();  
            for (int i = 1; i <= number; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
            for (int j = 1; j < number; j++)
            {
                Console.WriteLine("*");
            }
            for (int k = 1; k <= number; k++)
            {
                Console.Write("* ");
            }
            Console.Read();
        }
    }
}
