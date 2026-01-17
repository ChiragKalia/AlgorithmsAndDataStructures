using System;

namespace DataStructures.LinkedLists
{
    public class DetectCycleII
    {
        /// <summary>
        /// https://leetcode.com/problems/linked-list-cycle-ii/
        /// Finds the node where the cycle begins in a linked list.
        /// Core Pattern: Two-Phase Tortoise and Hare.
        /// Time Complexity: O(N)
        /// Space Complexity: O(1)
        /// </summary>
        public ListNode DetectCycle(ListNode head)
        {
            // Initial pointers for Phase 1
            ListNode slow = head;
            ListNode fast = head;

            // PHASE 1: DETECT THE CYCLE
            // We move fast at 2x speed and slow at 1x speed.
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                // If they meet, a cycle is confirmed.
                if (slow == fast)
                {
                    // PHASE 2: FIND THE CYCLE ENTRANCE
                    // Mathematical Fact: The distance from the Head to the Entrance 
                    // is equal to the distance from the Meeting Point to the Entrance.

                    // Reset slow to the start (head).
                    slow = head;

                    // Move both pointers at the SAME speed (1x).
                    while (fast != slow)
                    {
                        slow = slow.next;
                        fast = fast.next;
                    }

                    // The point where they meet again is the entrance of the cycle.
                    return slow;
                }
            }

            // If fast reaches null, there is no cycle.
            return null;
        }
    }
}