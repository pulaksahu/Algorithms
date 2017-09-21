using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class ListNode<T>
    {
        public int Key { get; set; }
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }
        public ListNode<T> Previous { get; set; }

        public int GetKey()
        {
            return Key;
        }

        public T GetValue()
        {
            return Value;
        }

        public ListNode()
        {

        }

        public ListNode(int key, T value)
        {
            Key = key;
            Value = value;
        }

        //public ListNode(T value) { Value = value; }
    }
}
