using System;

namespace DataStructures.LinkedLists
{
    public class RotateLinkedList
    {
        /// <summary>
        /// https://leetcode.com/problems/rotate-list/description/
        /// Rotates the linked list to the right by K places.
        /// Strategy: Connect the tail to the head to make it circular, 
        /// then break the circle at the new tail.
        /// </summary>
        public ListNode RotateList(ListNode head, int K)
        {
            // Boundary Check: If the list is empty or has only one node, no rotation is needed.
            if (head == null || head.next == null) return head;

            // 1. MEASURE & FIND TAIL: Walk to the end to get the length and the last node.
            ListNode tail = head;
            int length = 1;
            while (tail.next != null)
            {
                tail = tail.next;
                length++;
            }

            // 2. NORMALIZE K: If K is larger than length, we only care about the remainder.
            // Example: Rotating 5 nodes by 7 is the same as rotating by 2.
            int n = K % length;

            // If the effective rotation is 0, just return the original list.
            if (n == 0) return head;

            // 3. IDENTIFY PIVOT: The new tail will be at (length - n) from the start.
            // For a list of 5, rotating 2 means the 3rd node becomes the new tail.
            ListNode nthNode = FindNthNode(head, length - n);

            // 4. THE REARRANGEMENT:
            // The node after the new tail is the new head.
            ListNode newHead = nthNode.next;

            // Connect the old tail to the old head to create a temporary ring.
            tail.next = head;

            // Sever the link after the new tail to turn the ring back into a linear list.
            nthNode.next = null;

            return newHead;
        }

        /// <summary>
        /// Helper to traverse exactly to the N-th node from the current head.
        /// </summary>
        private ListNode FindNthNode(ListNode head, int n)
        {
            ListNode temp = head;
            // Since we start at the 1st node, we move (n-1) times.
            while (n > 1)
            {
                temp = temp.next;
                n--;
            }
            return temp;
        }
    }
}