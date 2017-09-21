using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class PriorityQueueMax
    {
        private MaxHeap heap;

        public PriorityQueueMax()
        {
            heap = new MaxHeap();
        }
        
        /// <summary>
        /// O(log n)
        /// </summary>
        /// <param name="element"></param>
        public void Queue(int element)
        {
            heap.Add(element);
        }

        /// <summary>
        /// O(log n)
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            return heap.ExtractMax();
        }
    }
}
