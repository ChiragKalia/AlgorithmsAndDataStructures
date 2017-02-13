using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class PoisonousPlants
    {
        static int count = 0;
        public int countNumberOfDays(int length, List<int> A)
        {
            var expectedList = A.OrderByDescending(x => x);
            var equalLists = A.SequenceEqual(expectedList);
            if (equalLists)
            {
                return count;
            }
            else
            {
                List<int> originalList = new List<int>();
                foreach (int i in A)
                {
                    originalList.Add(i);
                }
                for (int i = 0; i < length - 1; i++)
                {
                    int Ai = A[i];
                    int Aiplus1 = A[i + 1];
                    if (Ai == -1 || Aiplus1 == -1)
                    {
                        Ai = originalList[i];
                        Aiplus1 = originalList[i + 1];
                    }
                    if (Ai < Aiplus1)
                    {
                        A[i + 1] = -1;
                    }

                }
                if (A.Contains(-1))
                {
                    A.RemoveAll(element => element == -1);
                    count++;
                    countNumberOfDays(A.Count, A);
                }
                return count;
            }

        }
    }
}
