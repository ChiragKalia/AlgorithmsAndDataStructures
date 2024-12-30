using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class BestTimeToBuySellStock
    {
        int MaxProfit(int[] arr)
        {
            int maxPro = 0, minPrice = Int32.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                minPrice = Math.Min(minPrice, arr[i]);
                maxPro = Math.Max(maxPro, arr[i] - minPrice);
            }
            return maxPro;
        }
    }
}
