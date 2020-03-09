using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    class ReverseWordsInAString
    {
        string ReverseWords(string s)
        {
            string[] strArray = s.Split(' ');
            string reversedStr = "";
            for (int i = strArray.Length - 1; i >= 0; i--)
            {
                reversedStr += strArray[i] + " ";
            }
            return reversedStr;
        }
    }
}
