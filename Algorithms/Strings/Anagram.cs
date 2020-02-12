using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class Anagram
    {
        public static bool CheckIfAnagram(string s1, string s2)
        {
            char[] c1 = s1.ToLower().ToCharArray();
            char[] c2 = s2.ToLower().ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            s1 = new string(c1);
            s2 = new string(c2);

            if (s1 == s2)
            {
                return true;
            }
            return false;
        }
    }
}
