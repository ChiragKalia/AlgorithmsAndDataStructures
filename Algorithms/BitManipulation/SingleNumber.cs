using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BitManipulation
{
    public class SingleNumber
    {
        //<summary>
        // A function that returns non duplicate number in a list which has two duplicates in linear time
        //</summary>
        //<param name="A">List with one non duplicate number</param>
        public int singleNumber(List<int> A)
        {
            int result = 0;
            foreach(int i in A)
            {
                result ^= i; 
            }
            return result;  
        }

        //<summary>
        // A function that returns non duplicate number in a list which has three duplicates of every number except one number in linear time
        //</summary>
        //<param name="A">List with one non duplicate number</param>
        public int singleNumberFromThreeDuplicates(List<int> A)
        {
            int result = 0;
            foreach (int i in A)
            {
                result ^= i;
            }
            return result;
        }

    }
}
