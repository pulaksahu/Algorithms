using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Node
    {
        public Node()
        {
        }
        public Node(int d)
        {
            this.Data = d;
        }
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    /// <summary>
    /// This class is fully tested and working fine
    /// </summary>
    public class BST
    {
        public Node Root { get; set; }       

        public Node Add(int data)
        {
            Node newNode = new Node(data);

            if(this.Root == null)
            {
                this.Root = newNode;
                return this.Root;
            }

            Node current = this.Root;
            Node parent = new Node();

            while (current != null)
            {
                parent = current;
                if (newNode.Data < current.Data)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            if (newNode.Data < parent.Data)
                parent.Left = newNode;
            else
                parent.Right = newNode;

            return this.Root;
        }

        public Node FindMinRecursive(Node current) // current is the root of the subtree or the tree
        {
            if (current.Left == null)
                return current;

            return FindMinRecursive(current.Left);
        }

        public Node FindMinIterative(Node current) // current is the root of the subtree or the tree
        {
            while(current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }

        public Node FindMaxRecursive(Node current) // current is the root of the subtree or the tree
        {
            if (current.Right == null)
                return current;

            return FindMaxRecursive(current.Right);
        }

        public Node FindMaxIterative(Node current)
        {
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current;
        }

        public Node FindNode(Node current, int data) // current is the root node of the subtree
        {
            if (current == null)
                return null;

            if(data < current.Data)
            {
                return FindNode(current.Left, data);
            }
            else if (data > current.Data)
            {
                return FindNode(current.Right, data);
            }
            else // found the node
            {
                return current;
            }
        }

        /// <summary>
        /// Depth First Search - inorder, preorder, postorder
        /// All DFS make use of stack 
        /// Implicit call stack in case of recursion, explicit stack data structure in case of iteration
        /// </summary>
        /// <param name="current"></param>
        public void PrintInorder(Node current)
        {
            if (current == null)
                return;

            PrintInorder(current.Left);
            Console.Write(current.Data.ToString() + " ");
            PrintInorder(current.Right);
        }

        /// <summary>
        /// Breadth first search - level order traversal
        /// BFS always makes use of queue data structure
        /// </summary>
        /// <param name="current"></param>
        public void PrintBFSIterative(Node current)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(current);

            while(q.Count() != 0)
            {
                current = q.Dequeue();

                Console.Write(current.Data.ToString() + " ");

                if (current.Left != null)
                    q.Enqueue(current.Left);
                if (current.Right != null)
                    q.Enqueue(current.Right);
            }
        }

        /// <summary>
        /// BFS or level order traversal using recursion
        /// Use of explicit queue object
        /// </summary>
        /// <param name="q"></param>
        public void PrintBFSRecursive(Queue<Node> q)
        {
            if (q.Count == 0)
                return;
            Node current = q.Dequeue();

            Console.Write(current.Data.ToString() + " ");

            if (current.Left != null)
                q.Enqueue(current.Left);
            if (current.Right != null)
                q.Enqueue(current.Right);

            PrintBFSRecursive(q);
        }

        public Node InOrderSuccessor(int data)
        {
            Node current = FindNode(this.Root, data);

            if (current == null)
                return null;
            // Case 1 : the node has a right subtree, successor would be the minimum of the right subtree of the node
            else if(current.Right != null) 
            {
                return FindMinIterative(current.Right);  // O(h) = O(log n)
            }
            // Case 2 : the node does not have a right sub tree - successor would be the deepest ancestor
            // of the current node greater than the current node 
            // (the current node is in the left subtree of this ancestor)
            else 
            {
                Node successor = null;
                Node temp = this.Root;

                // traverse the tree to the current node - O(h) = O(log n)
                // keep track of the ancestor of the current which is larger than current as this might be the successor
                while(temp != current)
                {
                    if(current.Data < temp.Data)
                    {
                        successor = temp;
                        temp = temp.Left;
                    }
                    else
                    {
                        temp = temp.Right;
                    }
                }
                return successor;
            }
        }

        public Node InOrderPredecessor(int data)
        {
            Node current = FindNode(this.Root, data);

            if (current == null)
                return null;
            // Case 1 : the node has a left subtree, Predecessor would be the max of the left subtree of the node
            else if (current.Left != null)
            {
                return FindMaxIterative(current.Left);  // O(h) = O(log n)
            }
            // Case 2 : the node does not have a left sub tree - Predecessor would be the deepest ancestor
            // of the current node lesser than the current node 
            // (the current node is in the right subtree of this ancestor)
            else
            {
                Node predecessor = null;
                Node temp = this.Root;

                // traverse the tree to the current node - O(h) = O(log n)
                // keep track of the ancestor of the current which is smaller than current as this might be the Predecessor
                while (temp != current)
                {
                    if (current.Data < temp.Data)
                    {
                        temp = temp.Left;
                    }
                    else
                    {
                        predecessor = temp;
                        temp = temp.Right;
                    }
                }
                return predecessor;
            }
        }

        public Node FindParent(Node root, Node current)
        {
            Node temp = root;
            Node parent = null;

            while(temp != current)
            {
                if(current.Data < temp.Data)
                {
                    parent = temp;
                    temp = temp.Left;
                }
                else if(current.Data > temp.Data)
                {
                    parent = temp;
                    temp = temp.Right;
                }                
            }
            return parent;
        }

        /// <summary>
        /// Handles corner cases like when root of the subtree is deleted
        /// It is a recursive function, so complete the 
        /// </summary>
        /// <param name="root">Root of the subtree in question</param>
        /// <param name="data">Data of the node being deleted</param>
        public void DeleteNode(Node root, int data)
        {
            Node current = FindNode(root, data);
            Node leftChild = current.Left;
            Node rightChild = current.Right;
            Node parent = FindParent(root, current);

            if(parent == null) // root node is being deleted
            {
                if (leftChild != null)
                {
                    // replace with max of left subtree or min of right subtree
                    Node maxOfLeft = FindMaxRecursive(current.Left);
                    current.Data = maxOfLeft.Data;

                    // finally delete the leaf node containing that data
                    DeleteNode(current.Left, maxOfLeft.Data);
                }
                else
                {
                    // replace with max of left subtree or min of right subtree
                    Node minOfRight = FindMinRecursive(current.Right);
                    current.Data = minOfRight.Data;

                    // finally delete the leaf node containing that data
                    DeleteNode(current.Right, minOfRight.Data);
                }
            }
            // Base case of recursion - min or max of a subtree would always be a leaf node
            // leaf node (node without any children) to be deleted
            else if(leftChild == null && rightChild == null) 
            {
                if (current.Data > parent.Data)
                    parent.Right = null;
                else
                    parent.Left = null;
            }
            else if(leftChild == null && rightChild != null)
            {
                if (current.Data > parent.Data)
                    parent.Right = rightChild;
                else
                    parent.Left = rightChild;
            }
            else if(rightChild == null && leftChild != null)
            {                
                if (current.Data > parent.Data)
                    parent.Right = leftChild;
                else
                    parent.Left = leftChild;
            }
            else // both children are not null
            {
                // replace with max of left subtree or min of right subtree
                Node maxOfLeft = FindMaxRecursive(current.Left);
                current.Data = maxOfLeft.Data;

                // finally delete the leaf node containing that data
                DeleteNode(current.Left, maxOfLeft.Data);
            }
        }
    }
}
