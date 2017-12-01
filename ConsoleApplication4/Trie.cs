using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class TrieNode
    {
        public Char? Data { get; set; }

        public Dictionary<Char, TrieNode> NextSet { get; set; }  // HashMap<Character, TrieNode>

        public Boolean IsWordEnding { get; set; }

        public TrieNode(Char d)
        {
            this.IsWordEnding = false;
            this.NextSet = new Dictionary<char, TrieNode>();
            this.Data = d;
        }

        public TrieNode()
        {
            // TODO: Complete member initialization
            this.NextSet = new Dictionary<char, TrieNode>();
            this.Data = null;
            this.NextSet = new Dictionary<char, TrieNode>();
        }
    }


    public class Trie
    {
        public TrieNode Root { get; set; }

        public Trie()
        {
            this.Root = new TrieNode();
        }

        /// <summary>
        /// Complexity is the number of characters in the word - O(n)
        /// </summary>
        /// <param name="word"></param>
        public void AddWord(string word)
        {
            // start from root node as current
            TrieNode current = this.Root;
            char[] wordCharacters = word.ToCharArray();  // char array of the word being added

            foreach(char c in wordCharacters)
            {
                // for each char in the word, move to the already existing next trie node 
                if(current.NextSet.ContainsKey(c))
                {
                    current = current.NextSet[c];
                }
                else // if this char does not exist, create a new node and add it to current node
                {
                    TrieNode newNode = new TrieNode(c);
                    current.NextSet.Add(c, newNode);
                    current = newNode;
                }
            }
            current.IsWordEnding = true; // at the end of the word, set the flag
        }

        /// <summary>
        /// Complexity - 
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public List<String> PrefixSearch(string prefix)
        {
            List<String> allWords = new List<string>();  // keep all the words found so far
            TrieNode current = this.Root;  // starting current node
            char[] prefixArray = prefix.ToCharArray(); // character array of the prefix word
            char[] word = new char[50];  // substring word created so far in a char array - 50 is the max length of a word
            int index = 0; // keep track of the index of the above char array

            // traverse till the end of the prefix, words found before end of the prefix are not included
            while(index < prefixArray.Length)
            {
                if(current.NextSet.ContainsKey(prefixArray[index]))
                {
                    current = current.NextSet[prefixArray[index]];
                    word[index] = current.Data.Value;
                    index++;
                }
                else
                {
                    allWords.Add(prefix);
                    return allWords;
                }
            }
            // we are at the last character of the prefix - current node => last char of the prefix
            // Complexity till now. O(k) where k is number of char in the prefix

            // if last char of prefix is a word ending, add this word to the list of all words
            if (current.IsWordEnding)
                allWords.Add(CreateWord(word));

            // Complexity of below - O(PM) where M is the number of char in the words and P is the number of words in the tree
            // traverse towards all the leafs of the trie - recursively
            foreach(TrieNode c in current.NextSet.Values)
            {
                TraverseAll(c, word, index, allWords);
            }

            // return all words collected  -  total complexity is O(k + PM)
            return allWords;
        }

        private void TraverseAll(TrieNode current, char[] word, int index, List<String> allWords)
        {
            // base condition - when this is the leaf node of the trie
            if (current.NextSet.Count == 0)
            {
                word[index] = current.Data.Value;
                index++;
                if (current.IsWordEnding)
                    allWords.Add(CreateWord(word));
                word[index] = '\0';
                return;
            }

            // add current char to the word so far
            word[index] = current.Data.Value;
            index++;

            // if a word is formed, all it to the list of words
            if (current.IsWordEnding)
                allWords.Add(CreateWord(word));

            // recursively traverse to the leaf nodes again
            foreach (TrieNode c in current.NextSet.Values)
            {
                TraverseAll(c, word, index, allWords);
            }

            word[index] = '\0'; // since this is a recursive function, it is important to reset the char array to default value
        }

        /// <summary>
        /// Helper function to create a string out of a char array
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private string CreateWord(char[] c)
        {
            String returnString = String.Empty;

            for(int i = 0; i < c.Length; i++)
            {
                if (c[i] != '\0')
                    returnString += c[i];
                else
                    break;
            }
            return returnString;
        }

        public Boolean WordExists(string word)
        {
            // start from the root node as current
            TrieNode current = this.Root;

            // take each character of the word, and search it against the current node's character value
            foreach (char c in word.ToCharArray())
            {
                // if the current char of the word is found, move on the next node and the next char of the word
                if (current.NextSet.ContainsKey(c))
                {
                    current = current.NextSet[c];
                }
                else // if any char of the word is not found in the node, the word does not exist, return false
                {
                    return false;
                }
            }

            // we are the last char node of the word - it may be a word or not based on the IsWordEnding flag of the node
            return current.IsWordEnding;
        }
    }
}
