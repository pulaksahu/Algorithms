using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}

    public class MyClass
    {
        private int a;
        public double b;

        static int[] fib = new int[41];

        public MyClass(int first, double second)
        {
            this.a = first;
            this.b = second;
        }

        public class LinkedList
        {
            public class Node
            {
                // link to next Node in list
                public Node next = null;
                // value of this Node
                public int data;
            }

            private Node root = null;

            public Node First { get { return root; } }

            public Node Last
            {
                get
                {
                    Node curr = root;
                    if (curr == null)
                        return null;
                    while (curr.next != null)
                        curr = curr.next;
                    return curr;
                }
            }

            public void Append(int value)
            {
                Node newNode = new Node();
                newNode.data = value;

                Node curr = root;

                Node last = new Node();

                while(curr != null)
                {
                    last = curr;
                    curr = curr.next;
                }
                last.next = newNode;
            }

            public void PrintLinkedList()
            {
                Node current = root;
                Console.WriteLine();


                while(current != null)
                {
                    Console.Write(root.data.ToString() + " ");
                    current = current.next;
                }
            }

            public Node addTwoNumbers(Node l1, Node l2)
            {

                int i = 0;
                bool carryOne = false;
                Node ret = new Node();
                Node prev = new Node();

                while (l1 != null || l2 != null || carryOne)
                {
                    int result = 0;

                    if (l1 == null)
                    {
                        result = l2.data + 0;
                    }
                    else if (l2 == null)
                    {
                        result = l1.data + 0;
                    }
                    else
                    {
                        result = l1.data + l1.data;
                    }

                    if (carryOne)
                    {
                        result += 1;
                        carryOne = false;
                    }

                    if (result > 9)
                    {
                        carryOne = true;
                        result = result % 10;
                    }

                    Node current = new Node();
                    current.data = result;

                    if (i == 0)
                    {
                        ret = current;
                        i++;
                    }
                    if (prev != null)
                    {
                        prev.next = current;
                    }
                    prev = current;

                    l1 = l1.next;
                    l2 = l2.next;
                }
                return ret;
            }
        }

        public static void Main(String[] args)
        {


            int target = 5;

            //int[] a = { 1, 2, 1, 3, 2, 5 };


            //int[] result = GetSum(a, target);


            int x = hammingWeight(2147483648);
            
           

            Console.Read();
        }

        public static int[] countBits(int num)
        {

            int[] result = new int[num + 1];

            for (int i = 0; i <= num; i++)
            {
                int j = 0;

                int k = i;
                while (k != 0)
                {
                    if (k % 2 == 1)
                    {
                        j++;
                    }

                    k = k / 2;
                }
                result[i] = j;
            }
            return result;
        }


        public static int hammingWeight(uint n)
        {

            int count = 0;

            for (int i = 0; i < 32; i++)
            {
                if ((n & (1 << i)) != 0)
                {
                    count++;
                }
            }

            return count;
        }


        public static int[] singleNumber(int[] nums) {
        
        int xor = 0;
        
        int[] result = new int[2];
        
        foreach(int i in nums)
        {
            xor = xor ^ i;  //cancel out all the duplicate numbers
        }
        
        
        int j = 0;
        
        foreach(int k in nums)
        {
            if((xor^k) == 0)
            {
                result[j] = k;
                j++;
            }
        }
        return result;
    }

        public static int[] GetSum(int[] a, int target)
        {
            int[] result = new int[2];

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if(dict.ContainsKey(a[i]))
                {
                    result[0] = dict[a[i]];
                    result[1] = a[i];
                    break;
                }
                else
                {
                    dict.Add(target - a[i], a[i]);
                }
            }
            
            return result;
        }


        public static int FindFirstOccurence(int[] a, int x, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
                return -1;

            int i = (endIndex + startIndex) / 2;

            if (x > a[i])
            {
                return FindFirstOccurence(a, x, i + 1, endIndex);
            }
            else if (x < a[i])
            {
                return FindFirstOccurence(a, x, startIndex, i - 1);
            }
            else // if(a[i] == x)
            {
                return a[i];
            }
        }


        public static void MergeSortRecursion(int[] numbers)
        {
            if (numbers.Length < 2)
                return;

            int mid = numbers.Length / 2;
            int[] firstHalf = new int[mid];
            int[] secondHald = new int[numbers.Length - mid];

            for(int i = 0; i < numbers.Length; i++)
            {
                if(i < mid)
                {
                    firstHalf[i] = numbers[i];
                }
                else
                {
                    secondHald[i - mid] = numbers[i];
                }
            }

            MergeSortRecursion(firstHalf);
            MergeSortRecursion(secondHald);

            Merge(numbers, firstHalf, secondHald);
        }

        public static void Merge(int[] numbers, int[] left, int[] right)
        {
            int i = 0, j = 0 , k = 0;
            
            while(i < left.Length && j < right.Length)
            {
                if(left[i] <= right[j])
                {
                    numbers[k] = left[i];
                    i++;
                }
                else
                {
                    numbers[k] = right[j];                    
                    j++;
                }
                k++;
            }
            while (i < left.Length)
            {
                numbers[k++] = left[i++];
            }
            while (j < right.Length)
            {
                numbers[k++] = right[j++];
            }
        }


        public static void QuickSort(int[] a)
        {
            QuickSort(a, 0, a.Length - 1);
        }

        public static void QuickSort(int[] a, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
                return;

            int partitionIndex = Partition(a, startIndex, endIndex);

            QuickSort(a, startIndex, partitionIndex - 1);
            QuickSort(a, partitionIndex + 1, endIndex);
        }

        /// <summary>
        /// Random partitioning avoids the worst case scenario of quick sort ie. O(n2)
        /// Instead it tends to be close to O(nlog n) almost always.
        /// Hitting worst case scenario of O(n2) becomes zero.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        private static int RandomPartition(int[] a, int startIndex, int endIndex)
        {
            Random r = new Random();
            int newPivot = r.Next(startIndex, endIndex);

            Swap(ref a[endIndex], ref a[newPivot]);

            return Partition(a, startIndex, endIndex);
        }

        private static int Partition(int[] a, int startIndex, int endIndex)
        {
            int partitionIndex = startIndex;    // initialize partitionIndex as the startIndex, increase each time...
            int pivot = a[endIndex];            // endIndex element is the pivot

            // do not include the endIndex in the loop because that is the pivot
            for (int i = startIndex; i < endIndex; i++) 
            {
                if(a[i] < pivot)
                {
                    Swap(ref a[i], ref a[partitionIndex]);
                    partitionIndex++;
                }
            }

            //swap the pivot with the partitionIndex to correctly partition the array
            Swap(ref a[endIndex], ref a[partitionIndex]);            
            
            return partitionIndex;
        }

        public static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }

        public static long factorial(long n)
        {
            if (n >= 2)
                return n * factorial(n - 1);
            else
                return n;
        }


        public static int Fib(int n)
        {
            if (fib[n] != -1)
                return fib[n];
            else
            {
                int f = Fib(n - 1) + Fib(n - 2);
                fib[n] = f;
                return f;
            }
        }

        public static void BubbleSort(int[] a)
        { 
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i; j < a.Length; j++)
                {
                    if(a[i] > a[j])
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
        }

        public static void SelectionSort(int[] a)
        {
            for (int j = 0; j < a.Length; j++)
            {
                int min = a[j];
                int p = -1;

                for (int i = j + 1; i < a.Length; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                        p = i;
                    }
                }
                if (p != -1)
                {
                    Swap(ref a[j], ref a[p]);
                }
            }
        }


        public static List<int> Maxset(List<int> a)
        {
            Dictionary<int, int> IndexSumMap = new Dictionary<int, int>();

            int sum = 0;
            bool addStart = false;
            int maxSum = 0;
            int maxIndex = 0;


            for (int i = 0; i < a.Count; i++)
            {
                if(a[i] >= 0)
                {
                    sum += a[i];
                    addStart = true;
                    IndexSumMap[i] = sum;
                }
                else if(addStart)
                {                    
                    sum = 0;
                    addStart = false;
                }
            }

            foreach(var x in IndexSumMap)
            {
                int key = x.Key;
                int value = x.Value;

                if(value >= maxSum)
                {
                    maxSum = value;
                    maxIndex = key;
                }
            }

            int sumTemp = 0;
            List<int> ret = new List<int>();


            if (IndexSumMap.Count == 0)
                return ret;

            do
            {
                sumTemp += a[maxIndex];

                ret.Add(a[maxIndex]);

                maxIndex--;
            }
            while (maxIndex >= 0 && sumTemp != maxSum);

            return ret;
        }
    }
}
