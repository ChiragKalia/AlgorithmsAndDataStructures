using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
    /// <summary>
    /// Represents a node in a singly linked list, containing an integer value and a reference to the next node.
    /// </summary>
    /// <remarks>Use this class to construct and traverse singly linked lists, where each node holds a value
    /// and a link to the next node in the sequence. The class is commonly used in algorithms and data structures that
    /// require linked list manipulation.</remarks>
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
