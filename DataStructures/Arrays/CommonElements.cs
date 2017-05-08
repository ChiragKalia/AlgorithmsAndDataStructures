using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class CommonElements
    {
        public int[] GetCommonElements(int[,] A, int n)
        {
            int[] commonElements = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] tempArr = new int[n];
                for (int j = 0; j < n; j++)
                {
                    if (i == 0)
                    {
                        commonElements[j] = A[i, j];
                    }
                    else
                    {
                        tempArr[j] = A[i, j];
                    }
                }
                if (i > 0)
                {
                    commonElements = commonElements.Intersect(tempArr).ToArray();
                }
            }
            return commonElements;
        }

        public int[] GetCommonElementsUsingDictionary(int[,] A, int n) //Not Complete yet// Has Bug
        {
            int[] commonElements = new int[n];
            Dictionary<int, int> commonElementsDict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int arrValue = A[i, j];
                    if (commonElementsDict.ContainsKey(arrValue))
                    {
                        commonElementsDict[arrValue] += 1; 
                    }
                    else
                    {
                        commonElementsDict.Add(arrValue, 1);
                    }
                }
            }
            commonElements = commonElementsDict.Where(i=>i.Value== n).Select(i=>i.Key).ToArray();
            return commonElements;
        }
    }
}
