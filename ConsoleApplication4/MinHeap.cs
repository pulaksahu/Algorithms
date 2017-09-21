using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public interface IMinHeap
    {
         int GetMin();
         void Add(int a);
    }

    public class MinHeap : IMinHeap
    {
        private static int SIZE;
        private int[] data;
        private int nextElement;

        public MinHeap() 
        {
            SIZE = 20;
            data = new int[SIZE];
            nextElement = 0;
        }

        public MinHeap(int[] a)
        {
            SIZE = a.Length * 2;
            data = new int[SIZE];
            
            for(int x = 0; x < a.Length; x++)
            {
                data[x] = a[x];
            }
            nextElement = a.Length;

            for(int i = nextElement / 2; i >= 0; i--)
            {
                Heapify(i);
            }
        }

        private int GetParentIndex(int elementIndex)
        {
            if (elementIndex > 0)
                return (elementIndex - 1) / 2;
            else
                return -1;
        }

        private int GetLeftChild(int elementIndex)
        {
            if (2 * elementIndex + 1 < nextElement)
                return data[2 * elementIndex + 1];
            else
                return -1;
        }

        private int GetRightChild(int elementIndex)
        {
            if (2 * elementIndex + 2 < nextElement)
                return data[2 * elementIndex + 2];
            else
                return -1;
        }

        private int GetSmallestChildIndex(int index)
        {
            int leftChild = GetLeftChild(index);
            int rightChild = GetRightChild(index);

            if(leftChild != -1 && rightChild == -1)
            {
                return 2 * index + 1;
            }
            else if(leftChild == -1 && rightChild != -1)
            {
                return 2 * index + 2;
            }
            else if(leftChild == -1 && rightChild == -1)
            {
                return -1;
            }
            else
            {
                if (leftChild < rightChild)
                    return 2 * index + 1;
                else
                    return 2 * index + 2;
            }
        }

        private void ResizeIfConstrained()
        {
            if(nextElement >= SIZE * 0.8)
            {
                int[] newData = new int[SIZE * 2];
                SIZE = SIZE * 2;

                for(int i = 0; i < nextElement; i++)
                {
                    newData[i] = data[i];
                }
                data = newData;
            }
        }        

        /// <summary>
        /// Return the root
        /// Place the last child/leaf of the tree as root
        /// Bubble down the root to appropriate place in the heap
        /// </summary>
        /// <returns></returns>
        public int GetMin()
        {
            if (nextElement == 0)
                return -1;
            else
            {
                int min = data[0];

                // Pull last element of the heap to the front - root
                // Last element is now 0 (none)
                data[0] = data[nextElement - 1];
                data[nextElement - 1] = 0;
                nextElement--;

                // Bubble down the first element/root of the heap to appropriate place in the heap
                // This will retain the heap property of the tree
                Heapify(0);

                // Return the previous root of the heap
                return min;
            }
        }

        public int PeekMin()
        {
            return data[0];
        }


        public void SetRoot(int a)
        {
            data[0] = a;
        }

        /// <summary>
        /// Heapify the sub-tree with current index as the root
        /// Bubble down the current index input parameter to the right place in the heap
        /// </summary>
        /// <param name="currentIndex"></param>
        public void Heapify(int currentIndex)
        {
            while (GetSmallestChildIndex(currentIndex) != -1
                    && data[currentIndex] > data[GetSmallestChildIndex(currentIndex)])
            {
                int smallestChildIndex = GetSmallestChildIndex(currentIndex);
                SwapIndices(ref currentIndex, ref smallestChildIndex);

                currentIndex = smallestChildIndex;
            }

            ResizeIfConstrained();
        }

        /// <summary>
        /// Adding element to a heap is O(log n)
        /// where n is the number of elements in the heap
        /// </summary>
        /// <param name="a"></param>
        public void Add(int a)
        {
            //ResizeIfConstrained();

            data[nextElement] = a;
            nextElement++;

            int currentIndex = nextElement - 1;
            int parentIndex = GetParentIndex(currentIndex);
            int currentElement = a;


            //while(parentIndex >= 0 && currentIndex >= 0 && data[currentIndex] < data[parentIndex])
            //{
            //    SwapIndices(ref currentIndex, ref parentIndex);

            //    currentIndex = parentIndex;
            //    parentIndex = GetParentIndex(currentIndex);
            //}

            while(parentIndex >= 0)
            {
                Heapify(parentIndex);

                parentIndex = GetParentIndex(parentIndex);
            }
        }

        private void SwapIndices(ref int a, ref int b)
        {
            int t = data[a];
            data[a] = data[b];
            data[b] = t;
        }
    }
}
