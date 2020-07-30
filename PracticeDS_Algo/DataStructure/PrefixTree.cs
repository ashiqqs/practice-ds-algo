using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.DataStructure
{
    //Trie
    public class PrefixTree
    {
        public PrefixTree()
        {
            Root = new Node();
        }
        private Node Root { get; set; }

        /// <summary>
        /// TimeComplexity O(length)
        /// </summary>
        /// <param name="word"></param>
        public void Insert(string word)
        {
            word = word.ToLower();
            Node temp = Root;
            foreach (var ch in word)
            {
                int ch_idx = ch - 'a';
                if (temp.Next[ch_idx] == null)
                {
                    temp.Next[ch_idx] = new Node();
                }
                temp = temp.Next[ch_idx];
            }
            temp.EndMark = true;
        }

        /// <summary>
        /// TimeComplexity O(length)
        /// </summary>
        /// <param name="word"></param>
        public bool Contains(string word)
        {
            Node temp = Root;
            word = word.ToLower();
            foreach (var ch in word)
            {
                int ch_idx = ch - 'a';
                if(temp.Next[ch_idx] is null)
                {
                    return false;
                }
                temp = temp.Next[ch_idx];
            }
            return temp.EndMark;
        }
    }

    class Node
    {
        public Node()
        {
            Next = new Node[26 + 1];
            for(int i=0; i<26; i++)
            {
                Next[i] = null;
            }
        }
        public bool EndMark { get; set; }
        public Node[] Next { get; set; }
    }
}
