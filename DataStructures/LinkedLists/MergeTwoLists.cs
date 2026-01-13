using System;

namespace DataStructures.LinkedLists
{
    public class MergeTwoLists
    {
        /// <summary>
        /// https://leetcode.com/problems/merge-two-sorted-lists/
        /// Merges two sorted linked lists in-place.
        /// Time Complexity: O(n + m) - Where n and m are lengths of the lists.
        /// Space Complexity: O(1) - We reuse existing nodes and only create a dummy head.
        /// </summary>
        public ListNode MergeTwoLinkedLists(ListNode list1, ListNode list2)
        {
            // 1. Create a dummy node to act as the 'anchor' for our new list.
            // This makes it easy to return the start of the list later (dummy.next).
            ListNode dummy = new ListNode(0);

            // 2. 'tail' is the engine of our new train. 
            // We use it to attach the next smallest "box" (node).
            ListNode tail = dummy;

            // 3. Compare the heads of both 'trains' as long as both have boxes left.
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    // Attach the engine to the current box in list1.
                    tail.next = list1;
                    // Move the list1 head to the next box in its original chain.
                    list1 = list1.next;
                }
                else
                {
                    // Attach the engine to the current box in list2.
                    tail.next = list2;
                    // Move the list2 head forward.
                    list2 = list2.next;
                }

                // Move the engine forward to the box we just attached.
                tail = tail.next;
            }

            // 4. THE "TRAIN HOOKUP" MOMENT:
            // If one list is empty, we don't need a loop. We just hook our tail
            // to the start of the remaining list, and the entire "snake" follows.
            if (list1 != null)
            {
                tail.next = list1;
            }

            if (list2 != null)
            {
                tail.next = list2;
            }

            // Return the first real node (the one after our placeholder dummy).
            return dummy.next;
        }
    }
}