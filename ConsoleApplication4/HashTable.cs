using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class HashTableElement
    {
        private int key;
        private object value;

        public HashTableElement(int key, object value)
        {
            this.key = key;
            this.value = value;
        }

        public int GetKey()
        {
            return key;
        }

        public object GetValue()
        {
            return value;
        }
    }

    public class HashTable
    {
        private static int TABLE_SIZE = 52;

        private HashTableElement[] DataArray;

        public HashTable()
        {
            DataArray = new HashTableElement[TABLE_SIZE];

            for(int i = 0; i < TABLE_SIZE; i++)
            {
                DataArray[i] = null;
            }
        }

        private int HashFunction(int key)
        {
            return key % TABLE_SIZE;
        }

        public void Add(int key, object value)
        {
            int index = HashFunction(key);

            while(DataArray[index] != null)
            {
                if(DataArray[index].GetKey() != key)
                {
                    index++; // keep looking in the array until you find a empty location
                }
                else if (DataArray[index].GetKey() == key)
                {
                    throw new ApplicationException("Cannot add the same key twice.");
                }
            }
            // insert element into array only when there is no element in that location
            DataArray[index] = new HashTableElement(key, value);
        }

        public void Remove(int key)
        {
            int index = HashFunction(key);

            while (DataArray[index] != null)
            {
                if (DataArray[index].GetKey() == key)
                {
                    DataArray[index] = null;
                }

                index++;
            }
        }

        public bool Contains(int key)
        {
            int index = HashFunction(key);

            bool retValue = false;

            while (DataArray[index] != null)
            {
                if (DataArray[index].GetKey() == key)
                {
                    retValue = true;
                    break;
                }
                index++;
            }
            return retValue;
        }

        public object Get(int key)
        {
            int index = HashFunction(key);

            while(DataArray[index] != null && DataArray[index].GetKey() != key)
            {
                index++;
            }
            if (DataArray[index] != null && DataArray[index].GetKey() == key)
            {
                return DataArray[index].GetValue();
            }
            else // DataArray[index] == null
            {
                return -1;    // key does not exist in the hashtable
            }
        }

        public void PrintAll()
        {
            for(int i = 0; i < TABLE_SIZE; i++)
            {
                HashTableElement e = DataArray[i];

                if (e != null)
                {
                    Console.WriteLine(String.Format("Index {0}  {1}  {2}", i, e.GetKey(), e.GetValue()));
                }
                else
                {
                    Console.WriteLine(String.Format("Index {0}  {1}  {2}", i, "", ""));
                }
            }
        }
    }
}
