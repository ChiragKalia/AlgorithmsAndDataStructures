using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Greedy
{
    public class FractionalKnapsack
    {
        /// <summary>
        /// Calculates the maximum total value possible in a knapsack of a given capacity.
        /// This is a Greedy algorithm where we can take fractions of items.
        /// Time Complexity: O(N log N) for sorting.
        /// Space Complexity: O(N) to store the sorted array.
        /// </summary>
        /// <param name="capacity">Maximum weight the knapsack can hold.</param>
        /// <param name="arr">Array of available items.</param>
        /// <param name="n">Number of items in the array.</param>
        /// <returns>The maximum total value as a double.</returns>
        public double CalculateMaxValue(int capacity, Item[] arr, int n)
        {
            if (n == 0 || capacity == 0) return 0.0;

            // 1. Greedy Choice: Sort items by their value-to-weight ratio in descending order.
            // We cast to (double) to prevent integer division (e.g., 5/2 = 2.0) 
            // and ensure precise floating-point ratios (e.g., 5/2 = 2.5).
            arr = arr.OrderByDescending(i => (double)i.Value / i.Weight).ToArray();

            double totalValue = 0.0;
            int remainingCapacity = capacity;

            // 2. Iterate through sorted items and fill the knapsack greedily.
            for (int i = 0; i < n; i++)
            {
                // If the entire item can fit into the remaining capacity
                if (arr[i].Weight <= remainingCapacity)
                {
                    totalValue += arr[i].Value;
                    remainingCapacity -= arr[i].Weight;
                }
                // If the item is too heavy, take only a fraction to fill the remaining space
                else
                {
                    // Ratio represents the value of 1 unit of weight of this item
                    double valuePerUnitWeight = (double)arr[i].Value / arr[i].Weight;

                    // Add the value of the fraction that fits
                    totalValue += valuePerUnitWeight * remainingCapacity;

                    // Knapsack is now exactly full, so we stop here
                    break;
                }

                // Optimization: If capacity is 0, no need to check remaining items
                if (remainingCapacity == 0) break;
            }

            return totalValue;
        }

        /// <summary>
        /// Represents an item with a specific value and weight.
        /// </summary>
        public class Item
        {
            public int Value;
            public int Weight;

            public Item(int value, int weight)
            {
                Value = value;
                Weight = weight;
            }
        }
    }
}