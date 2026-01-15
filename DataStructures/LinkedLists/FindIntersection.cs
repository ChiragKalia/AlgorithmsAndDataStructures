using System;

namespace DataStructures.LinkedLists
{
    public class FindIntersection
    {
        /// <summary>
        /// https://leetcode.com/problems/intersection-of-two-linked-lists/
        /// Finds the node where two singly linked lists intersect.
        /// Core Pattern: The Two-Pointer "Synchronized Path" (a + c + b = b + c + a)
        /// Time Complexity: O(N + M)
        /// Space Complexity: O(1)
        /// </summary>
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            // 1. Edge Case: If either list is empty, there can be no intersection.
            if (headA == null || headB == null) return null;

            // 2. Initialize two pointers at the heads of their respective lists.
            ListNode l1 = headA;
            ListNode l2 = headB;

            // 3. THE MAGIC LOOP:
            // If they intersect, they will meet at the intersection node.
            // If they don't, they will both hit null at the exact same time and exit.
            while (l1 != l2)
            {
                // 4. THE SWITCH: 
                // When l1 reaches the end of List A, jump it to the head of List B.
                // When l2 reaches the end of List B, jump it to the head of List A.
                l1 = (l1 != null) ? l1.next : headB;
                l2 = (l2 != null) ? l2.next : headA;

                // By doing this, both pointers travel: (My unique part) + (Shared part) + (Your unique part).
                // This "equalizes" the distance, making them arrive at the 'shared part' together.
            }

            // Return either l1 or l2 (they are now at the same node or both null).
            return l1;
        }
    }
}