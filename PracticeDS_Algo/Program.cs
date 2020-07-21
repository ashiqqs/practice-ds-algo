using PracticeDS_Algo.Algorithm.Search;
using PracticeDS_Algo.Algorithm.Sort;
using PracticeDS_Algo.DataStructure;
using System;
using System.Collections.Generic;

namespace PracticeDS_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest queue = new PriorityQueue(100);
            queue.Execute();
        }

    }
}
