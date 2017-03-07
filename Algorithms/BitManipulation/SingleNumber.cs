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
        // A function that returns non duplicate number in a list in linear time
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

    }
}
