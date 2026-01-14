using System;

namespace DataStructures.LinkedLists
{
    public class DeleteNode
    {
        /// <summary>
        /// https://leetcode.com/problems/delete-node-in-a-linked-list/description/
        /// Deletes a node from a singly linked list given only access to that node.
        /// Core Pattern: Identity Theft (Value Copying).
        /// Time Complexity: O(1)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="node">The node to be deleted. Guaranteed not to be the tail.</param>
        public void DeleteNodefromLinkedList(ListNode node)
        {
            // 1. COPY DATA: Since we can't 'unhook' the current node from its predecessor,
            // we copy the data from the NEXT node into the CURRENT node.
            // The current node now "becomes" its neighbor.
            node.val = node.next.val;

            // 2. UNHOOK NEIGHBOR: Now that this node has safely stolen the next node's identity,
            // the actual next node object is a duplicate. We bridge the gap by pointing 
            // this node's 'next' to the one after the neighbor (skipping the neighbor).
            node.next = node.next.next;

            // Result: The original node object remains in the list, but it now holds 
            // the next node's value and points to the node after that.
        }
    }
}