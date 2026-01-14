using System;

namespace DataStructures.LinkedLists
{
    public class AddTwoNumbers
    {
        /// <summary>
        /// https://leetcode.com/problems/add-two-numbers/
        /// Core Pattern: Simultaneous Traversal with Carry Management.
        /// Time Complexity: O(max(N, M)) where N and M are the lengths of the two lists.
        /// Space Complexity: O(max(N, M)) as we must create a new list for the sum.
        /// </summary>
        public ListNode AddTwoNumbersLL(ListNode l1, ListNode l2)
        {
            // 1. DUMMY NODE PATTERN: Create a fixed anchor to build our sum list.
            // Using a dummy simplifies the logic so we don't have to check 
            // if the 'head' of the result list exists yet.
            ListNode dummy = new ListNode(0);

            // 2. INCREMENTAL CONSTRUCTION: 'current' acts as our tail/builder pointer.
            ListNode current = dummy;

            // 3. STATE TRACKING: The 'carry' stores overflow from one column to the next.
            int carry = 0;

            // 4. THE MASTER LOOP: We keep walking as long as there is ANY work left.
            // This includes digits in l1, digits in l2, OR a final leftover carry digit.
            while (l1 != null || l2 != null || carry != 0)
            {
                // 5. VIRTUAL ZERO PATTERN: If one list is shorter, treat missing nodes as 0.
                // This allows us to use the same math regardless of list lengths.
                int l1Val = (l1 != null) ? l1.val : 0;
                int l2Val = (l2 != null) ? l2.val : 0;

                // 6. COLUMN ADDITION: Calculate the total for this digit position.
                int totalSum = l1Val + l2Val + carry;

                // Update carry for the next position (e.g., 18 / 10 = 1).
                carry = totalSum / 10;

                // 7. NEW CAR CREATION: Save the single digit in a new node (e.g., 18 % 10 = 8).
                // We attach the new node to our current tail.
                current.next = new ListNode(totalSum % 10);

                // 8. ADVANCE POINTERS: Move our construction worker forward to the new tail.
                current = current.next;

                // Move the input list pointers forward only if they aren't already null.
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            // 9. RETURN LOGIC: Skip the dummy anchor and return the start of the real train.
            return dummy.next;
        }
    }
}