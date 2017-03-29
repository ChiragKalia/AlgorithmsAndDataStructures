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
        public BSTNode Insert(BSTNode root, int data)
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
        public BSTNode GetNewNode(int data)
        {
            BSTNode NewNode = new BSTNode();
            NewNode.data = data;
            NewNode.left = null;
            NewNode.right = null;
            return NewNode;
        }
        public bool Search(BSTNode root, int data)
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
        private BSTNode nodeParent = new BSTNode();
        public BSTNode Delete(BSTNode root, int data)
        {
            if(root==null)
            {
                return root;
            }
            if (data < root.data)
            {
                if(root.left.data == data)
                {
                    //Node to be deleted is left of current node
                    nodeParent = root;
                }
                root.left = Delete(root.left, data);
            }
            else if (data > root.data)
            {
                if (root.left.data == data)
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
                else if(root.left == null)
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
            while (root.right != null)
            {
                root = root.right;
            }
            return root;
        }
    }

}
