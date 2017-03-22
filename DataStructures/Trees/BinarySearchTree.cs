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
            if(root==null)
            {
                return false;
            }
            if(root.data==data)
            {
                return true;
            }
            else if(data<= root.data)
            {
                return Search(root.left, data);
            }
            else
            {
                return Search(root.right, data); 
            }
        }
    }

}
