using System;

namespace DataStructures.LinkedLists
{
    public class RemoveNthNode
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
        /// Removes the Nth node from the end of the list in a single pass.
        /// Time Complexity: O(L) where L is the length of the list.
        /// Space Complexity: O(1) as we only use two pointers.
        /// </summary>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // 1. Create a dummy node pointing to head.
            // This acts as a "buffer" so 'slow' can sit BEFORE the head 
            // if we need to delete the very first node.
            ListNode dummy = new ListNode(0, head);

            // Both pointers start at the dummy station.
            ListNode slow = dummy;
            ListNode fast = dummy;

            // 2. CREATE THE GAP: Move the fast pointer N steps forward.
            // This sets the width of our sliding window.
            while (n > 0)
            {
                fast = fast.next;
                n--;
            }

            // 3. SLIDE THE WINDOW: Move both pointers at the same speed.
            // We stop when fast hits the LAST node (fast.next is null).
            // Because of the gap, 'slow' will be exactly one node BEFORE the target.
            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            // 4. THE UNHOOK: Skip the Nth node.
            // We change the 'next' hook of our slow node to point to the node 
            // AFTER the one we want to delete.
            slow.next = slow.next.next;

            // Return the actual start of the train (skipping our dummy placeholder).
            return dummy.next;
        }
    }
}