using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class CountNumberOfWords
    {
        public static int CountNumberOfSpaces(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            s = s.Trim();
            int number = 0;

            while (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
            }

            foreach (string x in s.Split(' '))
            {
                number++;
            }
            return number;
        }
    }
}
