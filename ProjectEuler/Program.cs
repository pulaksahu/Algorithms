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
            


            //myTree.PrintInorder(myTree.Root);
            //Console.WriteLine();
            //myTree.PrintInorderWithoutRecursion(myTree.Root);

            //Console.WriteLine();

            //int x = myTree.kthSmallest(myTree.Root, 2);


            //Node min = myTree.FindMinIterative(myTree.Root);

            //min = myTree.FindMinRecursive(myTree.Root);

            //Node max = myTree.FindMaxIterative(myTree.Root);

            //max = myTree.FindMaxRecursive(myTree.Root);

            //max.Data = -1;

            

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

            //var map = new Dictionary<int, HashSet<String>>();

            //PrintBrackets(4);


            //sortCharacters("adfceb");


            //int[] a = { 100, 44, 15, -11, 0, -88, 100, 102, 0};

            //int[] sorted = SortArray(a);


            //PrintAllPermutations("abcd".ToCharArray());


            //int total = 100;
            //int[] d = {2,5,6,19,21};
            //int[] dpMap = new int[total + 1];
            //var map = new Dictionary<int, int>();

            //int result = MinCoins(total, d, map);

            //int result2 = MinCoinsDP(total, d, dpMap);

            //int x = levenshteinDistance("abcdef", "azced");

            int[] a = {8,5,13,7 };
            int x = maxWin(a);

            Console.Read();
        }


        public static void PrintAllSubsets(char[] a)
        {
            char[] setSoFar = new char[a.Length];
            int index = 0;

            PrintAllSubsets(a, setSoFar, index);
        }

        public static void PrintAllPermutations(char[] a)
        {
            PrintAllPermutations(a, 0);
        }

        private static void PrintAllPermutations(char[] a, int i)
        {
            if(i == a.Length)
            {
                PrintAllCharInNewLine(a);
                return;
            }

            // swap i-th element of the char[] with each of the subsequent elements and call recursion
            for (int j = i; j < a.Length; j++)
            {
                Swap(a, i, j);   // fix j th element in the i th place and permute remaining array
                PrintAllPermutations(a, i + 1);  // leap of faith
                Swap(a, i, j);   // make the char[] or string as it was before - backtracking
            }
        }

        /// <summary>
        /// Classic example of inclusion-exclusion principle. Inclusion exclusion can be interchanged in order.
        /// Number of nodes in the recursion tree =>  2 ^ n  => Time complexity = O(2^n)   ... n is the no of char in the array
        /// Height of the recursion tree => log n => Space complexity = O(log n)       ... n is the no of char in the array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="setSoFar"></param>
        /// <param name="index"></param>
        private static void PrintAllSubsets(char[] a, char[] setSoFar, int index)
        {
            if (index == a.Length)
            {
                PrintAllCharInNewLine(setSoFar);
                return;
            }
            // Step 1 - Inclusion
            setSoFar[index] = a[index];            
            PrintAllSubsets(a, setSoFar, index + 1);

            // Step 2 - Exclusion  (step 1 and step 2 can be interchanged)
            setSoFar[index] = '\0';       // updating the same index is called backtracking
            PrintAllSubsets(a, setSoFar, index + 1);
        }

        /// <summary>
        /// Total space required is O(n + k)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private static int[] SortArray(int[] a)
        {
            int min = System.Int32.MaxValue;
            int max = System.Int32.MinValue;
            int[] result = new int[a.Length]; // auxilliary space required O(n) for int[] result

            // below loop is O(n)
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
            }
            int[] map = new int[max - min + 1]; // auxilliary space required O(k) for int[] map where k is the range of the integers

            int resultCount = 0;
            // below loop is O(n)
            for (int i = 0; i < a.Length; i++)
            {
                map[a[i] - min] += 1;
            }

            // below loop is O(k)
            for (int i = 0; i < map.Length; i++)
            {
                int count = map[i];

                for (int j = 0; j < count; j++)
                {
                    result[resultCount] = i + min;
                    resultCount++;
                }
            }
            return result;

            // total space required is O(n + k)
            // total time required is O(2n + k) => O(n + k)
        }

        static String sortCharacters(String inString)
        {

            char[] a = inString.ToCharArray();
            char[] result = new char[a.Length];
            int[] allCharCount = new int[256]; // all elements initialized to 0

            // below for loop will cost O(n)
            for (int i = 0; i < a.Length; i++)
            {
                int x = (int)a[i];
                allCharCount[x] += 1;
            }

            int resultCount = 0;

            // below loops will cost O(n)
            for (int i = 0; i < 256; i++)
            {
                int count = allCharCount[i];

                for (int j = 0; j < count; j++)
                {
                    result[resultCount] = (char)i;
                    resultCount++;
                }
            }

            return result.ToString();
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
            Console.Write(count + " - ");
            for(int i= 0; i < a.Length; i++)
            {  
                if(a[i] != '\0')
                    Console.Write(a[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Time complexity - O(d ^ height of the recursion tree H)
        /// Space complexity - O(height of the recursion tree H)
        /// It has many subproblems being solved again and again, so overlapping subproblems
        /// Problem solution is the combination of all its subproblems - optimal substructure
        /// If a problem has both above 2 properties - then it can be solved using DP (overlapping subproblems and optimal substructure)
        /// Recursion is solving the problem in a top-down approach of the recursion tree
        /// DP is solving the recursion tree from bottom-up approach
        /// DP can significantly improve time complexity eg., from exponential to linear is possible using DP
        /// </summary>
        /// <param name="total"></param>
        /// <param name="denominations"></param>
        /// <param name="map"></param>
        /// <returns></returns>
        public static int MinCoins(int total, int[] denominations, Dictionary<int, int> map)
        {
            if (total == 0)
                return 0;
            if (total < 0)
                return int.MaxValue;
            if (map.ContainsKey(total))
                return map[total];

            int min = int.MaxValue;
            
            foreach(int d in denominations)
            {
                if (d <= total)
                {
                    int x = MinCoins(total - d, denominations, map);
                    if (x < min)
                    {
                        min = x;
                    }
                }
            }
            if (min == int.MaxValue)
            {
                min = int.MaxValue;
                map.Add(total, min);
            }
            else
            {
                min = min + 1;
                map.Add(total, min);
            }
            return min;
        }

        /// <summary>
        /// Time Complexity - O(nD) where n is total value and D is the number of denominations
        /// Significant improvement in time complexity using DP. 
        /// Without dp, the time complexity was O(d ^ height of the recursion tree H) i.e., exponential
        /// Space complexity - O(n + 1) = O(n)
        /// </summary>
        /// <param name="total"></param>
        /// <param name="denominations"></param>
        /// <param name="map"></param>
        /// <returns></returns>
        public static int MinCoinsDP(int total, int[] denominations, int[] map)
        {
            if (total == 0)
                return 0;
            if (total < 0)
                return int.MaxValue;
            
            for (int i = 1; i < map.Length; i++) // f(0) => 0, start from 1
                map[i] = int.MaxValue;

            // below two loops have time complexity - O(n.D)
            for (int i = 1; i <= total; i++)
            {
                foreach (int d in denominations)
                {
                    if (d <= i)
                    {
                        if (map[i - d] != int.MaxValue && map[i - d] + 1 < map[i])
                        {
                            map[i] = map[i - d] + 1;
                        }
                    }
                }
            }
            return map[total];
        }

        private static void PrintAllNumbers(int[] coins)
        {
            Console.WriteLine();
            foreach (int s in coins)
            {
                 if(s != 0)
                    Console.Write(s + " ");
            }
        }

        static int levenshteinDistance(String strWord1, String strWord2) 
        {
            char[] w1 = strWord1.ToCharArray();
            char[] w2 = strWord2.ToCharArray();
        
            int[,] dp = new int[w1.Length + 1,w2.Length + 1];
        
            for(int i = 0; i <= w1.Length; i++)        
                dp[i,0] = i;
        
            for(int j = 0; j <= w2.Length; j++)        
                dp[0,j] = j;
        
            for(int i = 1; i <= w1.Length; i++)
                for(int j = 1; j <= w2.Length; j++)
                {
                    if(w1[i - 1] == w2[j - 1])
                        dp[i,j] = dp[i-1,j-1];
                    else
                        dp[i,j] = Math.Min(dp[i-1,j-1], Math.Min(dp[i,j-1], dp[i-1,j])) + 1;
                }
            return dp[w1.Length,w2.Length];
        }

        public static int maxWin(int[] intCoins) 
        {
            //HashMap<String, Integer> map = new  HashMap<String, Integer>();
            //return f(intCoins, 0, intCoins.length - 1, map);
        
            int l = intCoins.Length;
        
            int[,] dp = new int[l,l];
                    
            for(int g = 0; g < l; g++)
              for(int i = 0; i < l; i++)
              {
                  int j = i + g;
              
                  if(j < l)
                  {
                      if(i == j)
                      {
                          dp[i,j] = intCoins[i];
                      }
                      else if(j == i + 1)
                      {
                          dp[i,j] = Math.Max(intCoins[i], intCoins[j]);
                      }
                      else
                      {
                          dp[i,j] = Math.Max(intCoins[i] + Math.Min(dp[i + 2,j],dp[i+1,j-1]), intCoins[j] + Math.Min(dp[i+1,j-1],dp[i,j-2]));
                      }
                  }
              }
            return dp[0,l-1];
        }
    }
}
