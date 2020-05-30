using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class FindMissingNumber
    {
        public static void FindMissingNumberInSequence(int[] arr)
        {
            int expectedOutput = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                expectedOutput++;
                if (expectedOutput != arr[i])
                {
                    Console.WriteLine("Missing Number : " + expectedOutput);
                    expectedOutput++;
                }
            }
        }
    }
}
