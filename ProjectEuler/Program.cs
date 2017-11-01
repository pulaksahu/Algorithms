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
            #region TrieTestCode
            //Trie myTrie = new Trie();
            //myTrie.insert("p");
            //myTrie.insert("pulaks");
            //myTrie.insert("pul");
            //myTrie.insert("pulaksahu");
            
            //bool a = myTrie.search("asdf");
            //bool b = myTrie.search("pull");

            ///bool c = myTrie.startsWith("pulak");
            ///
            #endregion
            #region BSTTest
            ///
            //BST myTree = new BST();
            //myTree.Add(17);
            //myTree.Add(28);
            //myTree.Add(12);
            //myTree.Add(19);
            //myTree.Add(22);
            //myTree.Add(52);
            //myTree.Add(5);
            //myTree.Add(1);
            //myTree.Add(41);
            //myTree.Add(2);
            //myTree.Add(59);
            //myTree.Add(39);
            //myTree.Add(48);
            //myTree.Add(28);
            //myTree.Add(8);
            //myTree.Add(13);
            //myTree.Add(45);
            //myTree.Add(35);
            //myTree.Add(0);

            //Node min = myTree.FindMinIterative(myTree.Root);

            //min = myTree.FindMinRecursive(myTree.Root);

            //Node max = myTree.FindMaxIterative(myTree.Root);

            //max = myTree.FindMaxRecursive(myTree.Root);

            //max.Data = -1;

            //myTree.PrintInorder(myTree.Root);

            //myTree.PrintBFSIterative(myTree.Root);

            //Node x = new Node();
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
            //myTree.DeleteNode(myTree.Root, 35);

            //Console.WriteLine("");
            //myTree.PrintInorder(myTree.Root);

            //Queue<Node> q = new Queue<Node>();
            //q.Enqueue(myTree.Root);

            //myTree.PrintBFSRecursive(q);

            //Console.WriteLine("");
            //Console.WriteLine(myTree.IsBST());
            #endregion
            #region MergeSortTest
            int[] a = { 5, 0, 9, 6, 2, 1, 7, 4, 22, 8, 12, 11, 10, 19 };
            QuickSort(a);

            foreach (int i in a)
            {
                Console.Write(i.ToString() + " ");
            }
            #endregion
            #region MaximumSumSubArray
            //int[] a = { 25, 49, 29, 6, 2, 1, 7, 4, 22, 8, 12, 11, 10, 19 };

            //int[] b = { -2,-3,-12,-1, 12, -22, 1, 3,9,-13};

            //Console.WriteLine(MaxSumSubarray(b));
            #endregion
            #region LongestConsecutiveCharacter
            //char[] a = {'a','b','b','a','a','b','b','b','c','c','a'};
            //LongestConsecutiveCharacter(a);
            #endregion

            //int[] a = {1, 7, 3, 4};
            
            //int[] b = GetProductsOfAllIntsExceptAtIndex(a);




            Console.Read();
        }

        public static int MaxDifference(int[] a)
        {
            int min = a[0];   // contains minimum so far from left to right
            int maxDiff = a[1] - a[0]; // contains max difference between current element with minimum so far going from left to right

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] - min > maxDiff)
                    maxDiff = a[i] - min;

                if (a[i] < min)
                    min = a[i];
            }
            return maxDiff;
        }

        /// <summary>
        /// Using Kadane's algorithm to find max sum subarray
        /// Works even for all negative numbers or all positive numbers
        /// Most generic implementation
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int MaxSumSubarray(int[] a)
        {
            int currentSum = a[0];  // sum of the current subarray
            int max = a[0]; // maximum sum subarray in the array so far going from left to right - max among all the current subrarray sums

            for (int i = 1; i < a.Length; i++ )
            {
                //continue the existing subarray or begin a new one starting at a[i]
                currentSum = Math.Max(currentSum + a[i], a[i]);

                // a new subarray may have a sum greater than old subarray
                if (currentSum > max)
                    max = currentSum;
            }
            return max;

        }

        public static void LongestConsecutiveCharacter(char[] a)
        {
            int currentCount = 1;
            int maxCount = 0;
            char? maxChar = null;
            char prevChar = a[0];
            char currentChar;

            for(int i = 1; i < a.Length; i++)
            {
                currentChar = a[i];
                if (currentChar == prevChar)
                    currentCount++;
                else currentCount = 1;

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxChar = currentChar;
                }
                prevChar = currentChar;
            }

            Console.WriteLine(maxChar);
            Console.WriteLine(maxCount.ToString());
        }

        /// <summary>
        /// Dont use brute force, dont use division
        /// Make it happen in O(n)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int[] GetProductsOfAllIntsExceptAtIndex(int[] a)
        {
            int[] products = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
                products[i] = 1;

            for (int i = 0; i < a.Length; i++)
            {
                if(i != i - i) // 0
                    products[i - i] = products[i - i] * a[i];

            }
            return products;
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


        /// <summary>
        /// Merge sort is fast i.e., O(n log n) algorithm
        /// It needs aux arrays to sort, not an in place algorithm
        /// Not constant space algorithm
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int[] MergeSortNew(int[] a)
        {
            // base case of recursion
            if (a.Length < 2)
                return a;

            // split array into two
            int length = a.Length;
            int mid = length / 2;
            int[] left = new int[mid];
            int[] right = new int[length - mid];

            for(int c = 0; c < a.Length; c++)
            {
                if (c < mid)
                    left[c] = a[c];
                else
                    right[c - mid] = a[c];
            }

            // recursively call self to sort them
            int[] sortedLeft = MergeSortNew(left);
            int[] sortedRight = MergeSortNew(right);
            int[] sortedArray = new int[length];

            // merge the two sorted arrays into a single sorted array
            int i = 0; int j = 0; int k = 0;
            while(i < sortedLeft.Length && j < sortedRight.Length)
            {
                if(sortedLeft[i] < sortedRight[j])
                {
                    sortedArray[k] = sortedLeft[i];
                    i++;
                }
                else
                {
                    sortedArray[k] = sortedRight[j];
                    j++;
                }
                k++;
            }
            while(i < sortedLeft.Length)
            {
                sortedArray[k] = sortedLeft[i];
                i++; k++;
            }
            while (j < sortedRight.Length)
            {
                sortedArray[k] = sortedRight[j];
                j++; k++;
            }

            // return the merged sorted array
            return sortedArray;
        }

        /// <summary>
        /// Merge sort is great but it needs a lot of auxilliary arrays
        /// Lot of extra memory is needed
        /// Quick sort is equally fast but with constant space
        /// Also randomized quick sort works faster than merge sort
        /// Summary - quick sort is an in place algorithm with O(n log n) worst case complexity
        /// </summary>
        /// <param name="a"></param>
        public static void QuickSort(int[] a)
        {
            QuickSort(a, 0, a.Length - 1);
        }

        /// <summary>
        /// start and end indices are inclusive
        /// </summary>
        /// <param name="a"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void QuickSort(int[] a, int start, int end)
        {
            if(start < end) // base case of recursion
            {
                int pIndex = Partition(a, start, end);   // pIndex is the pivot index or partition index

                QuickSort(a, start, pIndex - 1);
                QuickSort(a, pIndex + 1, end);
            }
        }

        /// <summary>
        /// All elements to the left of pIndex are smaller than pivot
        /// All elements to the right of pIndex are greater than pivot
        /// The element at pIndex is called pivot
        /// </summary>
        /// <param name="a"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static int Partition(int[] a, int start, int end)
        {
            int pivot = a[end];  // or select pivot randomly using a rand() function
            int pIndex = start;

            for(int i = start; i < end; i++)
            {
                if(a[i] < pivot)
                {
                    Swap(a, i, pIndex);
                    pIndex++;
                }
            }
            Swap(a, pIndex, end);   // this will ensure than element at pIndex is the pivot
            return pIndex;   // return the partition index or the index of the pivot pIndex
        }

        private static void Swap(int[] a, int p1, int p2)
        {
            int t = a[p1];
            a[p1] = a[p2];
            a[p2] = t;
        }
    }
}
