using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {




            Trie myTrie = new Trie();
            myTrie.insert("p");
            myTrie.insert("pulaks");
            myTrie.insert("pul");
            myTrie.insert("pulaksahu");
            
            //bool a = myTrie.search("asdf");
            //bool b = myTrie.search("pull");

            bool c = myTrie.startsWith("pulak");
                        
            Console.Read();
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
