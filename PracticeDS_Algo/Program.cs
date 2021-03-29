using PracticeDS_Algo.Algorithm.Graph;
using PracticeDS_Algo.Algorithm.Search;
using PracticeDS_Algo.Algorithm.Sort;
using PracticeDS_Algo.DataStructure;
using System;
using System.Collections.Generic;

namespace PracticeDS_Algo
{
    class Program
    {
        //Searching an item from a descending sorted list using Binary Search
        static void Main(string[] args)
        {
            IGraph graph = new Graph();
            graph.Create();

            //IGraphTraverser bfs = new Bfs(graph);
            //bfs.Traverse();
            //bfs.PrintPath();

            IGraphTraverser dfs = new Dfs(graph);
            dfs.Traverse();
            dfs.PrintPath();

        }
    }
}
