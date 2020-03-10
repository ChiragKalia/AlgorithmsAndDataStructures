using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class NonRepeatingCharacter
    {
        static int numberOfCharacters = 256;
        static char[] count = new char[numberOfCharacters];
        static void GetCharCountArray(string str)
        {
            for (int i = 0; i < str.Length; i++)
                count[str[i]]++;
            for (int i = 0; i < str.Length; i++)
            {
                if (count[str[i]] == 1)
                {
                    Console.WriteLine("First Unique Character in the String Was " + str[i]);
                    break;
                }
            }
        }
    }
}
