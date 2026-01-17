using System;

namespace DataStructures.LinkedLists
{
    public class PalindromeLinkedList
    {
        /// <summary>
        /// https://leetcode.com/problems/palindrome-linked-list
        /// Checks if a linked list is a palindrome in O(N) time and O(1) space.
        /// Core Pattern: Middle Detection + Half-Reversal.
        /// </summary>
        public bool IsPalindrome(ListNode head)
        {
            // 1. FIND THE SPLIT POINT: Use Tortoise and Hare to find the middle.
            ListNode middleNode = FindMiddle(head);

            // 2. REVERSE THE SECOND HALF: To compare the end with the start,
            // we must flip the direction of the "second train" so it points inward.
            // Example: 1->2->2->1 becomes 1->2 (first half) and 1->2 (reversed second half).
            ListNode secondHalfHead = ReverseList(middleNode.next);

            // 3. COMPARISON: Iterate through both halves simultaneously.
            ListNode first = head;
            ListNode second = secondHalfHead;

            bool isPalindrome = true;
            while (second != null) // We only need to check until the end of the second half
            {
                if (first.val != second.val)
                {
                    isPalindrome = false;
                    break;
                }
                first = first.next;
                second = second.next;
            }

            // 4. CLEANUP (Optional but professional): Reverse the second half back 
            // to its original state to restore the input list.
            ReverseList(secondHalfHead);

            return isPalindrome;
        }

        /// <summary>
        /// Tortoise and Hare pattern to find the center of the list.
        /// </summary>
        private ListNode FindMiddle(ListNode head)
        {
            ListNode slow = head, fast = head;
            // For palindromes, we want the node just before the second half.
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        /// <summary>
        /// Standard iterative reversal to flip the link directions.
        /// </summary>
        private ListNode ReverseList(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;
            while (curr != null)
            {
                ListNode nextNode = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextNode;
            }
            return prev;
        }
    }
}