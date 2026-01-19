using System;

namespace DataStructures.LinkedLists
{
    public class CloneLinkedList
    {
        /// <summary>
        /// https://leetcode.com/problems/copy-list-with-random-pointer/description/
        /// Creates a deep copy of a linked list where each node has a 'next' and a 'random' pointer.
        /// Strategy: Interweave clones, map randoms, and de-interlace.
        /// </summary>
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;

            Node temp = head;

            // PASS 1: INTERWEAVE
            // Create a clone of each node and insert it immediately after the original.
            // Original: [A] -> [B] -> [C]
            // Result:   [A] -> [A'] -> [B] -> [B'] -> [C] -> [C']
            while (temp != null)
            {
                Node copyNode = new Node(temp.val);
                // Link clone to the original's next
                copyNode.next = temp.next;
                // Link original to the clone
                temp.next = copyNode;
                // Move to the next original node (skipping the clone we just added)
                temp = temp.next.next;
            }

            // PASS 2: MAP RANDOM POINTERS
            // Because the clone is right after the original, 
            // the clone's random is the original's random's NEXT.
            temp = head;
            while (temp != null)
            {
                Node copyNode = temp.next;
                if (temp.random == null)
                {
                    copyNode.random = null;
                }
                else
                {
                    // temp.random is the original target; .next is that target's clone.
                    copyNode.random = temp.random.next;
                }
                // Move to the next original node
                temp = temp.next.next;
            }

            // PASS 3: DE-INTERLACE (SEPARATION)
            // Restore the original list links and extract the clones into a new list.

            temp = head;
            Node dNode = new Node(-1); // Dummy node to build the copy list
            Node res = dNode;

            while (temp != null)
            {
                Node copyNode = temp.next;

                // 1. Connect the copy to the result list
                res.next = copyNode;
                res = res.next;

                // 2. Restore the original list's 'next' pointer
                // (Skip the clone to point back to the next original)
                temp.next = copyNode.next;

                // 3. Move to the next original node
                temp = temp.next;
            }

            return dNode.next;
        }

        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }
    }
}