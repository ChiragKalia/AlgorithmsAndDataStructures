using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    #region BinaryTree
        public class Node
        {
            public int key;
            public Node left, right;
            public int depth;
            public Node(int item)
            {
                key = item;
                left = right = null;
                depth = 0;
            }
        }
        public class BinaryTree
        {
            public Node root;
            public static int TotalLeafs;
            public BinaryTree(int key)
            {
                root = new Node(key);
            }
            public BinaryTree()
            {
                root = null;
            }
            static BinaryTree()
            {
                TotalLeafs = 0;
            }
            #region Depth First Traversal
                /* Inorder traversal of a binary tree*/
                public static void PreOrder(Node temp)
                {
                    if (temp == null)
                        return;
                    Console.WriteLine("Pre Order Traversal " + temp.key + " ");
                    PreOrder(temp.left);
                    PreOrder(temp.right);
                }
                /* Inorder traversal of a binary tree*/
                public static void InOrder(Node temp)
                {
                    if (temp == null)
                        return;
                    InOrder(temp.left);
                    Console.WriteLine("In Order Traversal " + temp.key + " ");
                    InOrder(temp.right);
                }
                /* Postorder traversal of a binary tree*/
                public static void PostOrder(Node temp)
                {
                    if (temp == null)
                        return;
                    PostOrder(temp.left);
                    PostOrder(temp.right);
                    Console.WriteLine("Post Order Traversal " + temp.key + " ");
                }
            #endregion
            #region Breadth First Insertion & Traversal
                public static void LevelOrderInsertion(Node temp, int key)
                {
                    Queue<Node> q = new Queue<Node>();
                    q.Enqueue(temp);

                    while (q.Count != 0)
                    {
                        temp = q.Peek();
                        q.Dequeue();

                        if (temp.left == null)
                        {
                            temp.left = new Node(key);
                            break;
                        }
                        else
                            q.Enqueue(temp.left);
                        if (temp.right == null)
                        {
                            temp.right = new Node(key);
                            break;
                        }
                        else
                            q.Enqueue(temp.right);
                    }
                }
                public static void LevelOrderTraversal(Node root)
                {
                    if (root == null) return;
                    Queue<Node> q = new Queue<Node>();
                    q.Enqueue(root);
                    while (q.Count != 0)
                    {
                        Node visited = q.Peek();
                        Console.WriteLine("The value of Node is: " + visited.key);
                        q.Dequeue();
                        if (visited.left != null)
                        {
                            q.Enqueue(visited.left);
                        }
                        if (visited.right != null)
                        {
                            q.Enqueue(visited.right);
                        }
                    }
                }
            #endregion
            public static int FindHeightOfTree(Node root)
            {
                if (root == null) return 0;
                int leftsubtreeheight = FindHeightOfTree(root.left);
                int rightsubtreeheight = FindHeightOfTree(root.right);
                return Math.Max(leftsubtreeheight, rightsubtreeheight) + 1;
            }
            public static void FindDepthOfNode(Node node, int depth)
            {
                if (node != null)
                {
                    node.depth = depth;
                    FindDepthOfNode(node.left, depth + 1); //Left Sub Tree
                    FindDepthOfNode(node.right, depth + 1); //Right Sub Tree
                }
            }
            public static void CountLeavesInTree(Node node)
            {
                if (node == null) return;
                if (node.left == null && node.right == null)
                {
                    ++TotalLeafs;
                }
                else
                {
                    CountLeavesInTree(node.left);
                    CountLeavesInTree(node.right);
                }
            }

            public static int FindDiameterOfBT(Node root)
            {
                if (root == null) return 0;
                int lHeight = FindHeightOfTree(root.left);
                int rHeight = FindHeightOfTree(root.right);
                int lDiameter = FindDiameterOfBT(root.left);
                int rDiameter = FindDiameterOfBT(root.right);
                return Math.Max(lHeight + rHeight + 1, Math.Max(lDiameter, rDiameter));
            }
            public static bool IsBTreeBalanced(Node root) //Program to check if the tree is Balanced
            {
                if (BalancedHeight(root) > -1) return true;
                return false;
            }
            private static int BalancedHeight(Node root)
            { //Helper method
                if (root == null) return 0;
                int lHeight = BalancedHeight(root.left);
                int rHeight = BalancedHeight(root.right);
                if (lHeight == -1 || rHeight == -1) return -1;
                if (Math.Abs(lHeight - rHeight) > 1) return -1;
                return Math.Max(lHeight, rHeight) + 1;
            }
    }
    #endregion
    //// Binary Tree Implementation
    ////Create Binary Tree and Insert Nodes
    //BinaryTree tree = new BinaryTree();
    //tree.root = new Node(1);
    //tree.root.left = new Node(2);
    //tree.root.right = new Node(3);
    ////tree.root.left.left = new node(4);
    ////tree.root.left.right = new node(5);
    ////tree.root.right.left = new node(6);
    ////tree.root.right.right = new node(7);
    //////Level Order Insertion
    //LevelOrderInsertion(tree.root, 4);
    //LevelOrderInsertion(tree.root, 5);
    //LevelOrderInsertion(tree.root, 6);
    //LevelOrderInsertion(tree.root, 7);

    //////Traverse Breadth First (Level Order)
    ////LevelOrderTraversal(tree.root);
    ////Traverse Depth First (Pre Order)
    ////PreOrder(tree.root);
    ////Console.WriteLine("------------------------------");
    //////Traverse Depth First (In Order)
    ////InOrder(tree.root);
    ////Console.WriteLine("------------------------------");
    //////Traverse Depth First (Pre Order)
    ////PostOrder(tree.root);
    ////Console.WriteLine(FindHeightOfTree(tree.root));
    ////FindDepthOfNode(tree.root, 0);
    ////Console.WriteLine(tree.root.left.depth);
    ////Count Total Number Of Leaves in Tree
    //CountLeavesInTree(tree.root);
    //Console.WriteLine(TotalLeafs);
}
