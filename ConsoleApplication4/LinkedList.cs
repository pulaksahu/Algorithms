using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class LinkedList<T>
    {       
        private ListNode<T> head;
        private ListNode<T> tail;
        public UInt64 Size { get; private set; }

        public LinkedList()
        {
            Size = 0;

            // Add sentinel nodes - head and tail
            head = new ListNode<T>();
            tail = new ListNode<T>();

            head.Next = tail;
            tail.Previous = head;
        }

        public ListNode<T> GetHead()
        {
            return head;
        }

        public void RotateLinkedList(int k)
        {
            if (k <= 0)
                return;

            while (k > 0)
            {
                ListNode<T> lastNode = tail.Previous;

                ListNode<T> secondLastNode = lastNode.Previous;

                ListNode<T> firstNode = head.Next;

                ListNode<T> secondNode = firstNode.Next;

                head.Next = lastNode;

                lastNode.Previous = head;

                lastNode.Next = firstNode;

                firstNode.Previous = lastNode;

                secondLastNode.Next = tail;

                tail.Previous = secondLastNode;

                k--;
            }
        }

        public void RotateLinkedListRecursive(int k)
        {
            if (k <= 0)
            {
                return;
            }
            else
            {
                ListNode<T> lastNode = tail.Previous;

                ListNode<T> secondLastNode = lastNode.Previous;

                ListNode<T> firstNode = head.Next;

                ListNode<T> secondNode = firstNode.Next;

                head.Next = lastNode;

                lastNode.Previous = head;

                lastNode.Next = firstNode;

                firstNode.Previous = lastNode;

                secondLastNode.Next = tail;

                tail.Previous = secondLastNode;

                RotateLinkedListRecursive(k - 1);
            }
        }

        public int GetSize()
        {
            int size = 0;

            ListNode<T> curr = head.Next;

            while(curr.Value != null)
            {
                size++;

                curr = curr.Next;
            }

            return size;
        }

        public int GetSizeRecursive(ListNode<T> head)
        {
            //int size = 0;

            if(head.Next.Value == null)
            {
                return 0;
            }
            else
            {
                return 1 + GetSizeRecursive(head.Next);
            }
        }

        public void Swap(T element1, T element2)
        {
            if(!Contains(head, element1) || !Contains(head, element2))
            {
                Console.WriteLine("Please make sure both the elements exist in the linked list.");
            }
            else
            {
                ListNode<T> curr = head.Next;

                ListNode<T> firstElement = new ListNode<T>();
                ListNode<T> secondElement = new ListNode<T>();

                while(curr.Value != null)
                {
                    if(element1.Equals(curr.Value))
                    {
                        firstElement = curr;
                    }
                    if(element2.Equals(curr.Value))
                    {
                        secondElement = curr;
                    }
                    curr = curr.Next;
                }

                T temp = firstElement.Value;
                firstElement.Value = secondElement.Value;
                secondElement.Value = temp;
            }
        }

        // Merge two sorted linked lists

        // Merge sort for linked list

        // Rotate a linked list by k number int



        public void PrintAll()
        {
            ListNode<T> current = head.Next; // first one is sentinel. Second one is possibly the real node with data.

            while (current.Value != null)
            {
                Console.WriteLine("Key = " + current.Key + "    Value = " + current.Value);

                current = current.Next;
            }
        }

        public void AddToFront(int key, T element)
        {
            ListNode<T> second = head.Next;

            ListNode<T> newNode = new ListNode<T>(key, element);

            newNode.Next = second;

            newNode.Previous = head;

            second.Previous = newNode;

            head.Next = newNode;

            Size++;
        }

        public void AddToLast(int key, T element)
        {
            ListNode<T> newNode = new ListNode<T>(key, element);

            ListNode<T> currentLast = tail.Previous;

            newNode.Next = tail;

            newNode.Previous = currentLast;

            currentLast.Next = newNode;

            tail.Previous = newNode;

            Size++;
        }

        public void ClearList()
        {
            head.Next = tail;
            tail.Previous = head;
            Size = 0;
        }

        public bool Remove(int key)
        {
            ListNode<T> current = head.Next;
            bool returnValue = false;

            while (current.Value != null)
            {
                if (current.Key.Equals(key))
                {
                    ListNode<T> previous = current.Previous;
                    ListNode<T> next = current.Next;

                    next.Previous = previous;
                    previous.Next = next;

                    if (Size > 0)
                    {
                        Size--;
                    }
                    returnValue = true;
                }
                current = current.Next;
            }
            return returnValue;
        }

        //public bool Remove(T element)
        //{
        //    ListNode<T> current = head.Next;
        //    bool returnValue = false;

        //    while(current.Value != null)
        //    {
        //        if(current.Value.Equals(element))
        //        {
        //            ListNode<T> previous = current.Previous;
        //            ListNode<T> next = current.Next;

        //            next.Previous = previous;
        //            previous.Next = next;

        //            if (Size > 0)
        //            { 
        //                Size--; 
        //            }
        //            returnValue = true;
        //        }
        //        current = current.Next;
        //    }
        //    return returnValue;
        //}

        public bool Contains(T element)
        {
            return Contains(head, element);
        }

        public bool Contains(ListNode<T> head, T element)
        {
            if (head.Next != null && head.Next.Value.Equals(element))
                return true;
            else if (head.Next != null)
                return Contains(head.Next, element);
            else
                return false;
        }

        public void Reverse()
        {
            ListNode<T> current = tail;
           
            ListNode<T> temp;

            while (current != null)
            {
                temp = current.Previous;

                current.Previous = current.Next;

                current.Next = temp;

                current = current.Next;
            }

            temp = head;
            head = tail;
            tail = temp;
        }
    }
}
