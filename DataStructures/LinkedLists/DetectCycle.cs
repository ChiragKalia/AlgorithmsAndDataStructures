using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
    public class DetectCycle
    {
        /// <summary>
        /// https://leetcode.com/problems/linked-list-cycle/
        /// Detects if a singly linked list has a cycle using Floyd's Tortoise and Hare algorithm.
        /// Time Complexity: O(N) - Each pointer traverses at most N nodes.
        /// Space Complexity: O(1) - No extra space is used.
        /// </summary>
        public bool HasCycle(ListNode head)
        {
            // 1. Boundary Check: If the list is empty or has only one node, no cycle is possible.
            if (head == null || head.next == null) return false;

            ListNode tortoise = head;
            ListNode hare = head.next;

            // 2. The Chase:
            while (tortoise != hare)
            {
                // SAFETY CHECK: If hare (or the node after it) hits null, 
                // there is no loop—the train tracks just end.
                if (hare == null || hare.next == null)
                {
                    return false;
                }

                tortoise = tortoise.next;      // 1 step
                hare = hare.next.next;         // 2 steps
            }

            // 3. The Collision: If they meet, a cycle exists!
            return true;
        }
    }
}
