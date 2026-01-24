using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Greedy
{
    public class MaxNMeetings
    {
        /// <summary>
        /// Determines the maximum number of meetings that can be performed in one room.
        /// Strategy: Greedy approach by sorting meetings based on their finish times.
        /// Time Complexity: O(N log N) due to sorting.
        /// Space Complexity: O(N) to store meeting structures.
        /// </summary>
        public List<int> MaxMeetings(int[] start, int[] end)
        {
            int n = start.Length;
            if (n == 0) return new List<int>();

            // 1. Data Transformation: Bundle parallel arrays into a list of structs.
            // Using a struct instead of a class improves cache locality and reduces GC pressure.
            List<Meeting> meetings = new List<Meeting>(n);
            for (int i = 0; i < n; i++)
            {
                meetings.Add(new Meeting(start[i], end[i], i + 1));
            }

            // 2. Greedy Sorting: Sort by End time.
            // If end times are equal, sorting by original position (ThenBy) ensures deterministic results.
            var sortedMeetings = meetings
                .OrderBy(m => m.End)
                .ThenBy(m => m.Pos)
                .ToList();

            List<int> result = new List<int>();

            // freeTime tracks the end of the last scheduled meeting.
            // Initialized to -1 or 0 depending on whether meetings can start at time 0.
            int freeTime = -1;

            // 3. Selection: Iterate through sorted meetings and pick the first available one.
            foreach (Meeting meet in sortedMeetings)
            {
                // If the meeting starts AFTER the room becomes free
                if (meet.Start > freeTime)
                {
                    result.Add(meet.Pos);
                    // Update freeTime ONLY when a meeting is successfully scheduled.
                    freeTime = meet.End;
                }
            }

            return result;
        }
    }

    /// <summary>
    /// Lightweight value type to encapsulate meeting data.
    /// Structs are stored inline in the list, providing better memory performance than classes for this scale.
    /// </summary>
    public struct Meeting
    {
        public int Start;
        public int End;
        public int Pos; // Original 1-based index

        public Meeting(int start, int end, int pos)
        {
            Start = start;
            End = end;
            Pos = pos;
        }
    }
}