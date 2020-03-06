using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class ReverseString
    {
        public static string ReverseTheString(string s)
        {
            int len = s.Length;
            string reverse = "";
            for (int i = len - 1; i >= 0; i--)
            {
                reverse += s[i];
            }
            return reverse;
        }

        public static string ReverseStringRecursively(string s, string reversed, int index)
        {
            if (index < s.Length)
            {
                reversed += s[s.Length - ++index];
                return ReverseStringRecursively(s, reversed, index);
            }
            return reversed;
        }
    }
}
