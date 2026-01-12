using System;

namespace DataStructures.LinkedLists
{
    public class ReverseLinkedList
    {
        /// <summary>
        /// Reverses a singly linked list iteratively.
        /// Time Complexity: O(n) - We visit each node exactly once.
        /// Space Complexity: O(1) - We only use a few pointer variables.
        /// 1 -> 2 -> 3 -> 4 -> 5 -> null 
        /// will become
        /// 5 -> 4 -> 3 -> 2 -> 1 -> null
        /// </summary>
        public ListNode ReverseList(ListNode head)
        {
            // 'curr' is our active node walker, starting at the beginning.
            ListNode curr = head;

            // 'prev' will eventually become the new head. 
            // It starts as null because the current head (1) will become the new tail.
            ListNode prev = null;

            // We continue until 'curr' walks off the end of the list (becomes null).
            while (curr != null)
            {
                // 1. TEMPORARILY SAVE the next node.
                // We must do this because we are about to break the link to it.
                ListNode next = curr.next;

                // 2. REVERSE the pointer.
                // Instead of pointing to the original next, point backwards to 'prev'.
                curr.next = prev;

                // 3. MOVE 'prev' forward.
                // The current node is now considered the "previous" for the next iteration.
                prev = curr;

                // 4. MOVE 'curr' forward.
                // We move to the node we saved in step 1.
                curr = next;
            }

            // After the loop, 'curr' is null and 'prev' is sitting on the last node processed.
            // This last node is the head of our new reversed list.
            return prev;
        }
    }
}