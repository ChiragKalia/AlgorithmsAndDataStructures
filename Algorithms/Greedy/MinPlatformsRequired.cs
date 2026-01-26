using System;

namespace Algorithms.Greedy
{
    public class MinPlatformsRequired
    {
        /// <summary>
        /// https://takeuforward.org/data-structure/minimum-number-of-platforms-required-for-a-railway
        /// Calculates the minimum number of platforms required so that no train waits.
        /// Logic: Treat arrivals and departures as independent events on a timeline.
        /// Time Complexity: O(N log N) - due to sorting the arrays.
        /// Space Complexity: O(1) - if we don't count the input storage.
        /// </summary>
        public int CountPlatforms(int n, int[] arr, int[] dep)
        {
            // 1. Sort both arrays independently. 
            // We lose the connection between a specific train's arrival and its departure, 
            // but for "maximum concurrent events," the identity of the train doesn't matter.
            Array.Sort(arr);
            Array.Sort(dep);

            int maxPlatformsNeeded = 0; // The global maximum found
            int currentPlatformsInUse = 0; // Current count of trains in the station

            int i = 0; // Pointer for arrivals
            int j = 0; // Pointer for departures

            // 2. Use a Two-Pointer approach to simulate the timeline.
            while (i < n)
            {
                // If a train arrives BEFORE the earliest scheduled departure,
                // we need a new platform.
                // Note: If arr[i] == dep[j], the problem usually dictates the train must
                // stay until the departure is finished. Check platform rules (usually arr <= dep).
                if (arr[i] <= dep[j])
                {
                    currentPlatformsInUse++;
                    i++;
                }
                // If a train departs before or at the time of the next arrival,
                // a platform becomes free.
                else
                {
                    currentPlatformsInUse--;
                    j++;
                }

                // 3. Keep track of the highest occupancy seen at any single point in time.
                maxPlatformsNeeded = Math.Max(currentPlatformsInUse, maxPlatformsNeeded);
            }

            return maxPlatformsNeeded;
        }
    }
}