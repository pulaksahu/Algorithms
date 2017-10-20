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

            Node min = myTree.FindMinIterative(myTree.Root);

            min = myTree.FindMinRecursive(myTree.Root);

            Node max = myTree.FindMaxIterative(myTree.Root);

            max = myTree.FindMaxRecursive(myTree.Root);

            //max.Data = -1;

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
            //myTree.DeleteNode(myTree.Root, 41);
            myTree.DeleteNode(myTree.Root, 35);

            //Console.WriteLine("");
            //myTree.PrintInorder(myTree.Root);

            //Queue<Node> q = new Queue<Node>();
            //q.Enqueue(myTree.Root);

            //myTree.PrintBFSRecursive(q);

            Console.WriteLine("");
            Console.WriteLine(myTree.IsBST());

            
            //int[] a = {5,0,9,6,2,1,7,4,22,8,12,11,10,19};

            //int[] b = MergeSort(a);

            //foreach(int i in b)
            //{
            //    Console.Write(i.ToString() + " ");
            //}

            Console.Read();
        }

        public static int[] MergeSort(int[] a)
        {
            if(a.Length <= 1)
            {
                return a;
            }

            int length = a.Length;
            int mid = length / 2;

            int[] left = new int[mid];
            int[] right = new int[length - mid];
                
            for(int i = 0; i < length; i++)
            {
                if (i < mid)
                    left[i] = a[i];
                else
                    right[i - mid] = a[i];
            }

            left = MergeSort(left);
            right = MergeSort(right);
            
            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] newArray = new int[left.Length + right.Length];

            int i, j, k;

            for(i = 0, j = 0, k = 0; i < left.Length && j < right.Length; k++)
            {
                if (left[i] < right[j])
                    newArray[k] = left[i++];
                else 
                    newArray[k] = right[j++];                
            }            
            while(j < right.Length)
            {
                newArray[k++] = right[j++];
            }
            while (i < left.Length)
            {
                newArray[k++] = left[i++];
            }
            return newArray;
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
