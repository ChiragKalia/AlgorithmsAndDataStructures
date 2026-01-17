using System;

namespace DataStructures.LinkedLists
{
    public class ReverseNodesKGroup
    {
        /// <summary>
        /// https://leetcode.com/problems/reverse-nodes-in-k-group
        /// Core Pattern: Segmented Reversal.
        /// We identify a block of K nodes, isolate it, reverse it, 
        /// and then stitch it back between the previous and next blocks.
        /// </summary>
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            // 1. STATE TRACKING
            ListNode prevNode = null; // Stores the tail of the PREVIOUSLY reversed group
            ListNode curr = head;     // The start of the CURRENT group to be reversed
            ListNode newHead = head;  // The final head of the entire list (returned at the end)

            while (curr != null)
            {
                // 2. SCOUTING: Find if there are enough nodes (k) to perform a reversal.
                ListNode kthNode = FindKthNode(curr, k);

                // If we have fewer than k nodes left, we stop reversing.
                if (kthNode == null)
                {
                    break;
                }

                // 3. ISOLATION: Temporarily sever the chunk from the rest of the train.
                ListNode nextNode = kthNode.next; // Save the start of the NEXT group
                kthNode.next = null;              // Cut the link to isolate this k-sized segment

                // 4. REVERSAL: Flip the isolated segment. 
                // Note: After flipping, 'curr' becomes the TAIL and 'kthNode' becomes the HEAD.
                ReverseLinkedList(curr);

                // 5. STITCHING (FRONT): Connect the previous part of the list to this new head.
                if (curr != head)
                {
                    // If this isn't the first group, connect the previous group's tail to this new head.
                    prevNode.next = kthNode;
                }
                else
                {
                    // If this is the very first group, the kthNode is now the new head of the entire list.
                    newHead = kthNode;
                }

                // 6. STITCHING (BACK): Connect the tail of our newly reversed group to the next group.
                prevNode = curr;       // Current 'tail' will be the 'prevNode' for the next iteration
                curr.next = nextNode;  // Link the tail to the start of the remaining unprocessed list

                // 7. ADVANCE: Move to the start of the next k-group.
                curr = curr.next;
            }

            return newHead;
        }

        /// <summary>
        /// Moves 'k-1' steps forward from the head to find the end of the group.
        /// </summary>
        private ListNode FindKthNode(ListNode head, int k)
        {
            ListNode curr = head;
            while (curr != null && k > 1)
            {
                curr = curr.next;
                k--;
            }
            return curr;
        }

        /// <summary>
        /// Standard iterative reversal logic.
        /// </summary>
        private ListNode ReverseLinkedList(ListNode head)
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