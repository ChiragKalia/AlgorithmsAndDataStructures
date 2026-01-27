using System;
using System.Collections.Generic;

public class CoinChange
{
    /// <summary>
    /// https://takeuforward.org/data-structure/find-minimum-number-of-coins
    /// Finds the minimum number of coins using a Greedy approach.
    /// Note: This only works for canonical coin systems (like standard currency).
    /// Time Complexity: O(V) in worst case (all 1s), but effectively O(Number of Denominations).
    /// Space Complexity: O(Number of coins returned).
    /// </summary>
    public IList<int> MinCoins(int[] coins, int V)
    {
        List<int> resList = new List<int>();

        // Ensure coins are sorted so we can pick the largest first
        Array.Sort(coins);

        int i = coins.Length - 1; // Start from the largest coin

        while (V > 0 && i >= 0)
        {
            while (coins[i] <= V)
            {
                V -= coins[i];
                resList.Add(coins[i]);
            }
            i--; // Only move to the next coin once the current one is too big
        }
        return resList;
    }
}