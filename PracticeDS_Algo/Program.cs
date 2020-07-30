using PracticeDS_Algo.Algorithm.Search;
using PracticeDS_Algo.Algorithm.Sort;
using PracticeDS_Algo.DataStructure;
using System;
using System.Collections.Generic;

namespace PracticeDS_Algo
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            PrefixTree trie = new PrefixTree();
            trie.Insert("ball");
            trie.Insert("bbc");
            trie.Insert("bat");
            Console.WriteLine(trie.Contains("bar"));
            Console.WriteLine(trie.Contains("ball"));

        }

    }
}
