using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trie myTrie = new Trie();
            //myTrie.insert("p");
            //myTrie.insert("pulaks");
            //myTrie.insert("pul");
            //myTrie.insert("pulaksahu");
            
            //bool a = myTrie.search("asdf");
            //bool b = myTrie.search("pull");

            ///bool c = myTrie.startsWith("pulak");
            ///
            BST myTree = new BST();
            myTree.Add(17);
            myTree.Add(28);
            myTree.Add(12);
            myTree.Add(19);
            myTree.Add(22);
            myTree.Add(52);
            myTree.Add(5);
            myTree.Add(1);
            myTree.Add(41);
            myTree.Add(2);
            myTree.Add(59);
            myTree.Add(39);
            myTree.Add(48);
            myTree.Add(28);
            myTree.Add(8);
            myTree.Add(13);
            myTree.Add(45);
            myTree.Add(35);
            myTree.Add(0);

            //Node min = myTree.FindMinIterative(myTree.Root);

            //min = myTree.FindMinRecursive(myTree.Root);

            //Node max = myTree.FindMaxIterative(myTree.Root);

            //max = myTree.FindMaxRecursive(myTree.Root);

            myTree.PrintInorder(myTree.Root);

            //myTree.PrintBFSIterative(myTree.Root);

            Node x = new Node();
            //x = myTree.FindNode(myTree.Root, 48);
            //x.Left = new Node(46);
            //x.Right = new Node(49);

            //x = myTree.InOrderPredecessor(19);
            //x = myTree.FindParent(x);
            //x = myTree.InOrderPredecessor(12);
            //x = myTree.FindParent(x);
            //x = myTree.InOrderPredecessor(59);
            //x = myTree.FindParent(x);
            myTree.DeleteNode(myTree.Root, 41);
            myTree.DeleteNode(myTree.Root, 17);

            Console.WriteLine("");
            myTree.PrintInorder(myTree.Root);

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(myTree.Root);

            myTree.PrintBFSRecursive(q);
                        
            Console.Read();
        }


        public static Boolean IsPrime(int number)
        {
            int boundary = Convert.ToInt32(Math.Floor(Math.Sqrt(number)));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
