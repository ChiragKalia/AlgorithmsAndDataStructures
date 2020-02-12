using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class FindAllSubstrings
    {
        public static void FindAllCombinations(string str, int n)
        {
            for (int length = 1; length <= n; length++)
            {
                // End index is tricky.
                for (int start = 0; start <= n - length; start++)
                {
                    string substring = str.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
