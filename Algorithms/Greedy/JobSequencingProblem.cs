using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Greedy
{
    public class JobSequencingProblem
    {
        /// <summary>
        /// https://takeuforward.org/data-structure/job-sequencing-problem
        /// Schedules jobs to maximize total profit given that each job takes 1 unit of time.
        /// Strategy: Greedy approach by Profit. We perform high-profit jobs as late as possible 
        /// to keep earlier slots open for more restrictive deadlines.
        /// </summary>
        /// <param name="arr">Array of Job objects containing Id, Deadline, and Profit.</param>
        /// <param name="n">Number of jobs.</param>
        /// <returns>A dictionary containing {TotalJobsScheduled, TotalMaxProfit}.</returns>
        public Dictionary<int, int> JobScheduling(Job[] arr, int n)
        {
            if (n == 0 || arr == null) return new Dictionary<int, int> { { 0, 0 } };

            // 1. Greedy Choice: Sort jobs by Profit in descending order.
            // We want to prioritize the most valuable jobs regardless of their deadlines.
            arr = arr.OrderByDescending(j => j.Profit).ToArray();

            // Find the maximum deadline to determine the size of our schedule/lookup array.
            int maxDeadline = arr.Max(j => j.Deadline);

            // 2. Reservation Table (1-based indexing).
            // Index 'i' represents the time slot (Day i). 
            // We use maxDeadline + 1 so we can use the deadline value itself as an index.
            int[] schedule = new int[maxDeadline + 1];
            Array.Fill(schedule, -1); // -1 indicates the slot is currently free.

            int jobsCount = 0;
            int totalProfit = 0;

            // 3. Process each job in the profit-sorted list.
            foreach (var job in arr)
            {
                // Search backwards from the job's deadline down to Day 1.
                // Doing a job as late as possible is the "Greedy Backfill" strategy.
                // This preserves earlier days for jobs that might have tighter deadlines.
                for (int day = job.Deadline; day > 0; day--)
                {
                    // If we find a free slot at or before the deadline...
                    if (schedule[day] == -1)
                    {
                        schedule[day] = job.Id; // Mark the slot as occupied by this job ID.
                        jobsCount++;
                        totalProfit += job.Profit;

                        // Once the job is scheduled, break the inner loop to process the next job.
                        break;
                    }
                }
            }

            // Standard return format for this problem: [Count, Total Profit]
            return new Dictionary<int, int> { { jobsCount, totalProfit } };
        }
    }

    public class Job
    {
        public int Id;
        public int Deadline;
        public int Profit;

        public Job(int id, int deadline, int profit)
        {
            Id = id;
            Deadline = deadline;
            Profit = profit;
        }
    }
}