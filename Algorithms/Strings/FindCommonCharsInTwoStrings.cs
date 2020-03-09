using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class FindCommonCharsInTwoStrings
    {
        static string common(string str1, string str2)
        {
            HashSet<Char> hs = new HashSet<char>();
            HashSet<Char> common = new HashSet<char>();
            foreach (char c in str1)
            {
                hs.Add(c); //Adds all unique characters into the HashSet
            }

            foreach (char c in str2)
            {
                if (hs.Contains(c))
                {
                    common.Add(c); //Adds all unique matching characters into the  
                }
            }
            return string.Join("", common); //Returns a string containing only unique common characters 
        }
    }
}
