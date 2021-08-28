using PracticeDS_Algo.Algorithm.Graph;
using PracticeDS_Algo.Algorithm.Search;
using PracticeDS_Algo.Algorithm.Sort;
using PracticeDS_Algo.DataStructure;
using System;
using static System.Console;
using System.Collections.Generic;
using PracticeDS_Algo.Algorithm.BookPractice;
using System.Linq;

namespace PracticeDS_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Permutation permutation = new Permutation();
            //permutation.GenPermutation(1);

            int source = 1;
            Dijkstra dijkstra = new Dijkstra();
            foreach (var item in dijkstra.GetDistance(source).Select((val, idx)=>(val,idx)))
            {
                if (item.idx < 1) continue;
                WriteLine($"From {source} to {item.idx} distance {item.val}");
            }
        }
    }
}
