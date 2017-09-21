using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class TrieNode
    {

        public char c;

        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();

        public bool isLeaf;

        // Initialize your data structure here.
        public TrieNode()
        {
        }

        public TrieNode(char x)
        {
            this.c = x;
            this.isLeaf = false;
        }
    }

    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        // Inserts a word into the trie.
        public void insert(string word)
        {

            TrieNode current = this.root;


            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];

                if (!current.children.ContainsKey(c))
                {                    
                    current.children.Add(c, new TrieNode(c));
                }

                current = current.children[c];
            }

            current.isLeaf = true;
        }

        // Returns if the word is in the trie.
        public bool search(String word)
        {
            TrieNode current = this.root;
            bool retVal = false;

            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];

                if (current.children.ContainsKey(c))
                {
                    current = current.children[c];

                    if (i == word.Length - 1)
                    {
                        if (current.isLeaf)
                        {
                            retVal = true;
                            break;
                        }
                        else
                        {
                            retVal = false;
                            break;
                        }
                    }
                }
                else
                {
                    retVal = false;
                    break;
                }
            }
            return retVal;
        }

        // Returns if there is any word in the trie
        // that starts with the given prefix.
        public bool startsWith(String prefix)
        {
            TrieNode current = this.root;
            bool retVal = true;

            for (int i = 0; i < prefix.Length; i++)
            {
                char c = prefix[i];

                if (current.children.ContainsKey(c))
                {
                    current = current.children[c];
                }
                else
                {
                    retVal = false;
                    break;
                }
            }
            return retVal;
        }

       
    }

    // Your Trie object will be instantiated and called as such:
    // Trie trie = new Trie();
    // trie.insert("somestring");
    // trie.search("key");
}
