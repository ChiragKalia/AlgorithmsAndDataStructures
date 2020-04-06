using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int key)
        {
            data = key;
            next = null;
        }
    }
    public class LinkedList
    {
        public static Node head;
        static void PrintList(Node head)
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine("Current Node's Data: " + currentNode.data);
                currentNode = currentNode.next;
            }
        }
        static void DeleteKeyFromList(int key)
        {
            Node current = head, prev = null;
            if (current != null && current.data == key)
            {
                head = current.next;
            }
            while (current != null && current.data != key)
            {
                prev = current;
                current = current.next;
            }
            if (current == null)
                return;
            prev.next = current.next;
        }
        static void DeleteKeyFromPosition(int pos)
        {
            Node current = head, prev = null;
            int index = 0;
            if (head == null)
                return;
            while (index <= pos)
            {
                if (index == pos)
                {
                    prev.next = current.next;
                    break;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
                index++;
            }
        }
        static void FindLengthOfLinkedList()
        {
            int length = 0;
            Node current = head;
            while (current != null)
            {
                current = current.next;
                length++;
            }
            Console.WriteLine("Length of the Linked List is :" + length);
        }
        static void DetectLoopInALinkedList()
        {
            Node current = head;
            if (current == null) return;
            HashSet<Node> hs = new HashSet<Node>();
            while (current != null)
            {
                if (hs.Contains(current))
                {
                    Console.WriteLine("Loop Found ");
                    return;
                }
                hs.Add(current);
                current = current.next;
            }
        }
        static void RemoveDuplicatesFromSortedLinkedList()
        {
            if (head == null) return;
            Node current = head, next_next;
            while (current.next != null)
            {
                if (current.data == current.next.data)
                {
                    next_next = current.next.next;
                    current.next = null;
                    current.next = next_next;
                }
                else
                {
                    current = current.next;
                }
            }
        }
        static void MoveLastElementToFrontInLinkedList()
        {
            Node current = head;
            int temp = head.data;
            while (current != null)
            {
                if (current.next == null)
                {
                    head.data = current.data;
                    current.data = temp;
                    break;
                }
                else
                {
                    current = current.next;
                }
            }
        }
        static Node IntersectTwoLinkedLists(Node n1, Node n2)
        {
            List<Node> finalList = new List<Node>();
            while (n1 != null && n2 != null)
            {
                if (n1.data == n2.data)
                {
                    finalList.Add(new Node(n1.data));
                    n1 = n1.next;
                    n2 = n2.next;
                }
                else if (n1.data < n2.data)
                {
                    n1 = n1.next;
                }
                else
                {
                    n2 = n2.next;
                }
            }
            for (int i = 0; i < finalList.Count - 1; i++)
            {
                finalList[i].next = finalList[i + 1];
            }
            return finalList.FirstOrDefault();
        }
        static Node MergeTwoSortedLinkedLists(Node n1, Node n2)
        {
            List<Node> finalList = new List<Node>();
            while (n1 != null && n2 != null)
            {
                if (n1.data == n2.data)
                {
                    finalList.Add(new Node(n1.data));
                    finalList.Add(new Node(n2.data));
                    n1 = n1.next;
                    n2 = n2.next;
                }
                else if (n1.data < n2.data)
                {
                    finalList.Add(new Node(n1.data));
                    n1 = n1.next;
                }
                else
                {
                    finalList.Add(new Node(n2.data));
                    n2 = n2.next;
                }
            }
            while (n1 != null)//For LeftOvers
            {
                finalList.Add(new Node(n1.data));
                n1 = n1.next;
            }
            while (n2 != null)
            {
                finalList.Add(new Node(n2.data));
                n2 = n2.next;
            }
            for (int i = 1; i < finalList.Count; i++)
            {
                finalList[i - 1].next = finalList[i];
            }
            return finalList[0];
        }
        public static void ReturnNthToLastNode(int n)
        {
            Node main_ptr = head;
            Node ref_ptr = head;
            int count = 0;
            if (head != null)
            {
                while (count < n)
                {
                    if (ref_ptr == null)
                    {
                        Console.WriteLine(n + " is greater than the no "
                                        + " of nodes in the list");
                        return;
                    }
                    ref_ptr = ref_ptr.next;
                    ++count;
                }
                while (ref_ptr != null)
                {
                    ref_ptr = ref_ptr.next;
                    main_ptr = main_ptr.next;
                }
                Console.WriteLine("The data of {0}th node from Last is: {1}", n, main_ptr.data);
            }
        }
        public static void ReverseLinkedList()
        {
            Node prev = null; Node current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }
    }

}
