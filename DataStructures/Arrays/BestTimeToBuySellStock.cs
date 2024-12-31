using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class BestTimeToBuySellStock
    {
        /*You are given an array prices where prices[i] is the price of a given stock on the ith day.

        You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

        Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

        https://leetcode.com/problems/best-time-to-buy-and-sell-stock
        https://takeuforward.org/data-structure/stock-buy-and-sell/
         */
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
