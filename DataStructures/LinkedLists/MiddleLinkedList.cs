using System;

namespace DataStructures.LinkedLists
{
    public class MiddleLinkedList
    {
        /// <summary>
        /// https://leetcode.com/problems/middle-of-the-linked-list/
        /// Finds the middle node of a singly linked list using Floyd's Tortoise and Hare algorithm.
        /// Time Complexity: O(n) - We traverse the list once.
        /// Space Complexity: O(1) - We only use two pointer variables.
        /// </summary>
        public ListNode FindMiddle(ListNode head)
        {
            // Both pointers start at the head of the list.
            ListNode tortoise = head;
            ListNode hare = head;

            // 'hare != null' ensures we haven't jumped past the end (Even lists).
            // 'hare.next != null' ensures the hare has a spot to land on its first jump (Odd lists).
            // We need both because the hare moves TWO steps at a time.
            while (hare != null && hare.next != null)
            {
                // Slow pointer moves 1 step.
                tortoise = tortoise.next;

                // Fast pointer moves 2 steps.
                hare = hare.next.next;
            }

            // When the hare reaches the end, the tortoise is exactly at the midpoint.
            // For even-length lists, this returns the second of the two middle nodes.
            return tortoise;
        }
    }
}