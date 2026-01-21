using System;

namespace DataStructures.Arrays
{
    public class TrappingRainwater
    {
        /// <summary>
        /// https://leetcode.com/problems/trapping-rain-water/description/
        /// Logic: Two-Pointer Approach.
        /// Time Complexity: O(N) - single pass.
        /// Space Complexity: O(1) - no extra arrays.
        /// </summary>
        public int Trap(int[] height)
        {
            // Boundary check: need at least 3 bars to trap water.
            if (height == null || height.Length < 3) return 0;

            int l = 0, r = height.Length - 1;
            int lMax = 0, rMax = 0;
            int total = 0;

            // We use l < r because once they meet, we've processed every gap.
            // A single bar at the meeting point cannot trap water on its own.
            while (l < r)
            {
                // We always process the side with the SHORTER bar.
                // Why? Because the amount of water is limited by the 'lower' boundary.
                // If height[l] is smaller, we know for sure that lMax is the bottleneck 
                // for the left side, regardless of how high rMax actually is.
                if (height[l] <= height[r])
                {
                    // Update the tallest bar seen so far from the left.
                    lMax = Math.Max(lMax, height[l]);

                    // Water trapped = (boundary height) - (current bar height).
                    // If lMax == height[l], this adds 0.
                    total += lMax - height[l];

                    l++;
                }
                else
                {
                    // Update the tallest bar seen so far from the right.
                    rMax = Math.Max(rMax, height[r]);

                    // Water trapped = (boundary height) - (current bar height).
                    total += rMax - height[r];

                    r--;
                }
            }

            return total;
        }
    }
}