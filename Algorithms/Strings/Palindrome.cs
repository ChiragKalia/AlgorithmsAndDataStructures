using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Uncategorized
{
    public class Palindrome
    {
        public static bool IsPalindrome(string str, int len)
        {
            int start = 0;
            int end = len - 1;
            while (true)
            {
                if (start > end)
                {
                    return true;
                }
                char a = str[start];
                char b = str[end];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                start++;
                end--;
            }
        }
    }
}
