using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class BinarySearchTree
    {
        public class BSTNode
        {
            public int data;
            public BSTNode left;
            public BSTNode right;
        }
        private BSTNode nodeParent = new BSTNode();

        public BSTNode Insert(BSTNode root, int data) //Insert a node in the binary search tree.
        {
            if (root == null)
            {
                root = GetNewNode(data);
            }
            else if (data <= root.data)
            {
                root.left = Insert(root.left, data);
            }
            else if (data >= root.data)
            {
                root.right = Insert(root.right, data);
            }
            return root;
        }
        public BSTNode GetNewNode(int data) // Initialize a new node
        {
            BSTNode NewNode = new BSTNode();
            NewNode.data = data;
            NewNode.left = null;
            NewNode.right = null;
            return NewNode;
        }
        public bool Search(BSTNode root, int data) //Search for a node in a BST, Returns true or false
        {
            if (root == null)
            {
                return false;
            }
            if (root.data == data)
            {
                return true;
            }
            else if (data <= root.data)
            {
                return Search(root.left, data);
            }
            else
            {
                return Search(root.right, data);
            }
        }
        public BSTNode Delete(BSTNode root, int data) //Deletes a node in a BST
        {
            if (root == null)
            {
                return root;
            }
            if (data < root.data)
            {
                if (root.left.data == data)
                {
                    //Node to be deleted is left of current node
                    nodeParent = root;
                }
                root.left = Delete(root.left, data);
            }
            else if (data > root.data)
            {
                if (root.right.data == data)
                {
                    //Node to be deleted is right of current node
                    nodeParent = root;
                }
                root.right = Delete(root.right, data);
            }
            else //Node to be deleted found
            {
                //Case 1: No Child
                if (root.left == null && root.right == null)
                {
                    root = null;
                    return root;
                }
                //Case 2: One Child
                else if (root.left == null)
                {
                    BSTNode temp = root;
                    root = root.right;
                    temp = null;
                    return root;
                }
                else if (root.right == null)
                {
                    BSTNode temp = root;
                    root = root.left;
                    temp = null;
                    return root;
                }
                //Case 3: Two Children
                else
                {
                    BSTNode temp = FindMin(root.right);
                    root.data = temp.data;
                    root.right = Delete(root.right, temp.data);
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            return root;
        }
        public BSTNode FindMin(BSTNode root)// Finds minimum value in the right subtree
        {
            while (root.left != null)
            {
                root = root.left;
            }
            return root;
        }
        public BSTNode FindMinValueInRightSubtree(BSTNode root)// Finds minimum value in the right subtree
        {
            if(root.left ==null) return null;
            while (root.left != null)
            {
                root = root.left;
            }
            return root;
        }
        public BSTNode Find(BSTNode root, int data) //Finds and returns a node if found in BST otherwise returns null
        {
            if (root == null)
            {
                return null;
            }
            else if (root.data == data)
            {
                return root;
            }
            else if (root.data > data)
            {
                return Find(root.left, data);
            }
            else
            {
                return Find(root.right, data);
            }
        }
        //In this method I am going to find the nearest inorder ancestor of a given element in a binary search tree 
        BSTNode GetSuccessor(BSTNode root, int data)
        {
            BSTNode current = Find(root, data);
            if (current == null) return null;
            if (current.right != null) //Case 1: If node has a right sub tree
                return FindMinValueInRightSubtree(current.right);
            else //Case 2: If node has no right sub tree then find deepest ancestor of given node
            {
                BSTNode successor = null;
                BSTNode ancestor = root;
                while(ancestor != current)
                {
                    if(current.data < ancestor.data)
                    {
                        successor = ancestor; //So far the deepest node for which the current node is left.
                        ancestor = ancestor.left;
                    }
                    else
                    {
                        ancestor = ancestor.right;
                    }
                }
                return successor;
            }
        }
        public BSTNode GetPredecessor(BSTNode root, int data)
        {
            BSTNode current = Find(root, data);
            if (current == null) return null; //Does not exist.
            BSTNode temp = current.left;
            if (temp != null) //For Case 1 where node has a left sub tree.
            { // We're going to walk the tree from root and find the parent of the current node since that will be it's parent.
                while (temp.right != null)
                {
                    temp = temp.right;
                }
            }
            else // For Case 2 where node has a right sub tree.
            {
                BSTNode predecessor = root;
                temp = root;
                while (current.data != temp.data)
                {
                    if (current.data > temp.data)
                    {
                        predecessor = temp;
                        temp = temp.right;
                    }
                    else temp = temp.left;
                }
                temp = predecessor;
            }
            return temp;
        }
    }
    //BINARY SEARCH TREE IMPLEMENTATION

    //BSTNode root = null;
    //root = Insert(root, 15);
    //root = Insert(root, 10);
    //root = Insert(root, 8);
    //root = Insert(root, 12);
    //root = Insert(root, 6);
    //root = Insert(root, 11);
    //root = Insert(root, 20);
    //root = Insert(root, 17);
    //root = Insert(root, 25);
    //root = Insert(root, 16);
    //root = Insert(root, 27);

    //Console.WriteLine("Enter Number To Be Searched: ");
    //int numberToBeSearched = Convert.ToInt32(Console.Read());
    //if(Search(root, numberToBeSearched) == true)
    //    Console.WriteLine("Found");
    //else
    //    Console.WriteLine("Not Found");

    //Delete(root, 15);

    //BSTNode successor = GetSuccessor(root, 12);
    //Console.WriteLine("The Successor of 12 is: "+ successor.data);

    //BSTNode predecessor = GetPredecessor(root, 25);
    //Console.WriteLine("The Predecessor is: " + predecessor.data);


}
