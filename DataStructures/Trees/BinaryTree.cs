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
            public static int val;
            public Node left, right;
            public static int depth;
            public Node(int item)
            {
                val = item;
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
                    Console.WriteLine("Pre Order Traversal " + temp.val + " ");
                    PreOrder(temp.left);
                    PreOrder(temp.right);
                }
                /* Iterative PreOrder traversal of a binary tree*/
                public static List<int> IterativePreOrder(Node root)
                {
                    List<int> list = new List<int>();
                    if (root == null)
                        return list;
                    Stack<Node> stack = new Stack<Node>();
                    stack.Push(root);
                    while (stack.Any())
                    {
                        Node temp = stack.Pop();
                        list.Add(temp.val);
                        if (temp.right != null) stack.Push(temp.right);
                        if (temp.left != null) stack.Push(temp.left);
                    }
                    return list;
                }
                /* Inorder traversal of a binary tree*/
                public static void InOrder(Node temp)
                {
                    if (temp == null)
                        return;
                    InOrder(temp.left);
                    Console.WriteLine("In Order Traversal " + temp.val + " ");
                    InOrder(temp.right);
                }
                /* Iterative InOrder traversal of a binary tree*/
                public static List<int> IterativeInOrder(Node root)
                { // Revisit
                    var res = new List<int>();

                    if (root == null)
                        return res;

                    var temp = root;
                    var st = new Stack<Node>();

                    while (temp != null || st.Count > 0)
                    {
                        if (temp != null)
                        {
                            st.Push(temp);
                            temp = temp.left;
                        }

                        if (temp == null && st.Count > 0)
                        {
                            var current = st.Pop();
                            Console.WriteLine(current.val);
                            res.Add(current.val);

                            temp = current.right;
                        }
                    }

                    return res;
                }
                /* Postorder traversal of a binary tree*/
                public static void PostOrder(Node temp)
                {
                    if (temp == null)
                        return;
                    PostOrder(temp.left);
                    PostOrder(temp.right);
                    Console.WriteLine("Post Order Traversal " + temp.val + " ");
                }
                /* Iterative PostOrder traversal of a binary tree*/
                public static List<int> IterativePostOrder(Node root)
                {
                    var res = new List<int>();
                    if (root == null) return res;
                    var st = new Stack<Node>();
                    st.Push(root);
                    Node prev = null;
                    while (st.Count > 0)
                    {
                        Node current = st.Peek();
                        if (prev == null || prev.left != current || prev.right != current)
                        {
                            if (current.left != null) st.Push(current.left);
                            if (current.right != null) st.Push(current.right);
                            else
                            {
                                st.Pop();
                                res.Add(current.val);
                            }
                        }
                        else if (current.left == prev)
                        {
                            if (current.right != null)
                                st.Push(current.right);
                            else
                            {
                                st.Pop();
                                res.Add(current.val);
                            }
                        }
                        else if (current.right == prev)
                        {
                            st.Pop();
                            res.Add(current.val);
                        }

                        prev = current;

                    }
                    return res;
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
                        Console.WriteLine("The value of Node is: " + visited.val);
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
            public static List<List<int>> ZigzagOrderTraversal(Node root)  //Revisit
            { //Breadth First ZigZag Traversal of Binary Tree 
                List<List<int>> lists = new List<List<int>>();
                Stack<Node> stack = new Stack<Node>();
                if (root != null) stack.Push(root);
                bool forward = true;

                while (stack.Count > 0)
                {
                    lists.Add(new List<int>());
                    Stack<Node> nextStack = new Stack<Node>();

                    while (stack.Count > 0)
                    {
                        Node n = stack.Pop();
                        lists[lists.Count - 1].Add(n.val);

                        if (forward)
                        {
                            if (n.left != null) nextStack.Push(n.left);
                            if (n.right != null) nextStack.Push(n.right);
                        }
                        else
                        {
                            if (n.right != null) nextStack.Push(n.right);
                            if (n.left != null) nextStack.Push(n.left);
                        }
                    }

                    forward = !forward;
                    stack = nextStack;
                }

                return lists;
            }
            public static bool CheckIfIdentical(Node tree1, Node tree2)
            { //Checks if two trees are identical in structure as well as values.
                if (tree1 == null && tree2 == null) return true;

                /* 2. both non-empty -> compare them */
                if (tree1 != null && tree2 != null)
                {
                    return (tree1.val == tree2.val && CheckIfIdentical(tree1.left, tree2.left) && CheckIfIdentical(tree1.right, tree2.right));
                }
                return false;
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
    //Console.WriteLine(FindDiameterOfBT(tree.root));
    //Console.WriteLine(IsBTreeBalanced(tree.root));
}
