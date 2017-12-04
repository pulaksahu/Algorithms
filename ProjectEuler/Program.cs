using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication4;
using ConsoleApasdf;

namespace ProjectEuler
{
    class Program
    {
        static int count = 0;
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
            //int[] a = { 5, 0, 9, 6, 2, 1, 7, 4, 22, 8, 12, 11, 10, 19 };
            //QuickSort(a);

            //foreach (int i in a)
            //{
            //    Console.Write(i.ToString() + " ");
            //}
            #endregion
            #region MaximumSumSubArray
            //int[] a = { 25, 49, 29, 6, 2, 1, 7, 4, 22, 8, 12, 11, 10, 19 };

            //int[] b = { 5,1,2,-3,7,-4 };

            //Console.WriteLine(MaxSumSubarray(b));
            #endregion
            #region LongestConsecutiveCharacter
            //char[] a = {'a','b','b','a','a','b','b','b','c','c','a'};
            //LongestConsecutiveCharacter(a);
            #endregion

            //int[] a = {1, 7, 3, 4};
            
            //int[] b = GetProductsOfAllIntsExceptAtIndex(a);

            #region MaxHeapNew

            //NewMaxHeap x = new NewMaxHeap();
            //x.Add(5);
            //x.Add(0);
            //x.Add(9);
            //x.Add(6);
            //x.Add(2);
            //x.Add(1);
            //x.Add(7);
            //x.Add(4);
            //x.Add(22);
            //x.Add(8);
            //x.Add(12);
            //x.Add(11);
            //x.Add(10);
            //x.Add(19);

            //int d = x.ExtractMax();
            //int E = x.ExtractMax();
            //int F = x.ExtractMax();
            ////int F = x.ExtractMax();
            //int H = x.ExtractMax(); ;
            //int I = x.ExtractMax();

            


            #endregion

            //Permute("GOOGLE");

            //AllSubSets("ABCEE");


            //LRUCache cache = new LRUCache(1);

            //cache.put(2, 1);            
            //cache.get(2);       // returns 1
            //cache.put(3, 2);    // evicts key 2
            //cache.get(2);       // returns -1 (not found)            
            //cache.get(3);       // returns 2 


            //Trie t = new Trie();
            //t.AddWord("but");
            //t.AddWord("butter");
            //t.AddWord("bat");
            //t.AddWord("batch");
            //t.AddWord("batter");
            //t.AddWord("battery");
            //t.AddWord("bye");
            //t.AddWord("better");
            //t.AddWord("buttery");
            //t.AddWord("bait");
            //t.AddWord("cat");
            //t.AddWord("catch");
            //t.AddWord("catatonical");
            //t.AddWord("catatonic");
            //bool a = t.WordExists("catatonical");
            //t.WordExists("car");

            //List<String> s = t.PrefixSearch("bat");

            var map = new Dictionary<int, HashSet<String>>();

            PrintBrackets(4);

            Console.Read();
        }


        public static void PrintBrackets(int n)
        {
            Dictionary<int, HashSet<String>> map = new Dictionary<int, HashSet<String>>();

            for (int i = 1; i <= n; i++)
            {
                var combos = Brackets(i, map);
                foreach(String x in combos)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Use of HashMap<> for memoization is a new thing learn
        /// Memoization significantly improves runtime complexity O(n) in this case
        /// Use of recursion/recursive thinking to solve this kind of problems
        /// Avoid duplicates by using HashSet<> in such problems
        /// </summary>
        /// <param name="i"></param>
        /// <param name="map"></param>
        /// <returns></returns>
        public static HashSet<String> Brackets(int i, Dictionary<int, HashSet<String>> map)
        {
            if (map.ContainsKey(i)) // memoization
                return map[i];
            else if(i == 1)  // base case of recursion
            {
                HashSet<String> combo = new HashSet<string>();
                combo.Add("()");
                map.Add(1, combo);
                return map[1];
            }
            else
            {
                HashSet<String> juniorCombo = new HashSet<string>();   // juniorCombo is Set of all strings for i-1 case
                HashSet<String> combo = new HashSet<string>();         // combo is Set of all string for i th case
                juniorCombo = Brackets(i - 1, map);

                foreach(String single in juniorCombo)
                {
                    combo.Add("(" + single + ")");
                    combo.Add("()" + single);

                    if(i > 2)     // for i >= 3 the single can be before or after the () - 2 different cases
                    {
                        combo.Add(single + "()");
                    }
                }
                map.Add(i, combo);  // add the set to the map (Dictionary) for memoization
                return combo;
            }
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
            int curSum = a[0];  // sum of the current subarray
            int maxSum = a[0]; // maximum sum subarray in the array so far going from left to right - max among all the current subrarray sums
            int sIndex = 0;
            int eIndex = 0;
            int maxStart = 0;
            int maxEnd = 0;

            for (int i = 1; i < a.Length; i++ )
            {
                //continue the existing subarray or begin a new one starting at a[i]
                if (a[i] > curSum + a[i])
                {
                    curSum = a[i];
                    sIndex = i; // start a new max sum subarray here
                    eIndex = i; // end Index of the newly started max sum subarray is the startIndex itself
                }
                else
                {
                    curSum = curSum + a[i];
                    eIndex = i;  // include this element in the existing max sum subarray - sliding window
                }

                // a new subarray may have a sum greater than old subarray
                if (curSum > maxSum)
                {
                    maxSum = curSum;
                    maxStart = sIndex;
                    maxEnd = eIndex;
                }
            }

            for (int i = maxStart; i <= maxEnd; i++)
            {
                Console.Write(a[i] + " ");
            }

            return maxSum;
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

            // Step 1 - split array into two
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

            // Step 2 - recursively call self to sort left and right segments of the array
            int[] sortedLeft = MergeSortNew(left);
            int[] sortedRight = MergeSortNew(right);
            int[] sortedArray = new int[length];

            // Step 3 - merge the two sorted arrays into a single sorted array
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

            // Step 4 - return the merged sorted array
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
                // Step 1. Partition the array around the pivot, left of the pivot are smaller, right of the pivot are greater than pivot element
                int pIndex = Partition(a, start, end);   // pIndex is the index of the pivot or partition index

                // Step 2. Recursively sort the left segment of the pivot
                QuickSort(a, start, pIndex - 1);

                // Step 3. Recursively sort the right segment of the pivot
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
            int pIndex = end;
            int pivot = a[start];  // you can take any element of the array segment, random element works best

            for(int i = end; i > start; i--)
            {
                if(a[i] > pivot)  // if any element is smaller than pivot, swap it to beginning of the array and increment the pIndex
                {
                    Swap(a, i, pIndex);
                    pIndex--;
                }
            }
            Swap(a, start, pIndex);  // move pivot to the partition index

            return pIndex;  // index of the pivot
        }

        private static void Swap<T>(T[] a, int p1, int p2)
        {
            T t = a[p1];
            a[p1] = a[p2];
            a[p2] = t;
        }

        public static void Permute(string s)
        {
            PrintPermutation(s.ToCharArray(), 0);
        }

        public static void AllSubSets(string str)
        {
            HashSet<char> SetSoFar = new HashSet<char>();
            HashSet<char> SetOfChar = new HashSet<char>();

            for (int i = 0; i < str.Length; i++)
            {
                SetOfChar.Add(str.ElementAt(i));   // this set will have each char only once, even duplicates will be once
            }

            PrintSubsets(0, SetSoFar, SetOfChar);
        }

        private static void PrintSubsets(int i, HashSet<char> SetSoFar, HashSet<char> SetOfChar)
        {
            if (i == SetOfChar.Count)
            {
                PrintAllCharInNewLineSubsets(SetSoFar);
                return;
            }

            SetSoFar.Add(SetOfChar.ElementAt(i));     // add first char to the set so far and proceed recursively
            PrintSubsets(i + 1, SetSoFar, SetOfChar);
            SetSoFar.Remove(SetOfChar.ElementAt(i));  // remove first char from the set so far and proceed recursively
            PrintSubsets(i + 1, SetSoFar, SetOfChar);
            
        }

        private static void PrintPermutation(char[] a, int j)
        {
            if (j == a.Length - 1)
            {
                PrintAllCharInNewLine(a);
                return;
            }

            for(int i = j; i < a.Length; i++)
            {
                Swap(a, i, j);

                PrintPermutation(a, j + 1);

                Swap(a, i, j);
            }
        }

        private static void PrintAllCharInNewLineSubsets(HashSet<char> a)
        {
            count++;
            Console.WriteLine(".");
            foreach (char s in a)
            {
                Console.Write(s);
            }
        }

        private static void PrintAllCharInNewLine(char[] a)
        {
            count++;
            Console.WriteLine();
            for(int i= 0; i < a.Length; i++)
            {                
                Console.Write(a[i]);
            }
        }
    }
}
