using PracticeDS_Algo.Algorithm.Search;
using PracticeDS_Algo.Algorithm.Sort;
using System;
using System.Collections.Generic;

namespace PracticeDS_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            ISorter sort = new Selection();
            string[] items = new string[] { "cat","catt", "dog", "bat", "bag", "bad" };
            helper.PrintArray<string>(items);
            var sorted = sort.Ascending(items);
            helper.PrintArray<string>(sorted);
            var desc = sort.Descending(items);
            helper.PrintArray<string>(desc);
        }
    }
}
