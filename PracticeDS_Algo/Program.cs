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
            /*
            0: 1,4
            1: 0,5
            2: 3,5,6
            3: 2,7
            4: 0
            5: 1,2,6
            6: 2,5,7
            7: 3,6
            */
            Bfs bfs = new Bfs();
            bfs.CreateGraph();
            bfs.Traverse();
            bfs.PrintPath();

        }
    }
}
