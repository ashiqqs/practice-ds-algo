using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Graph
{
    public interface IGraph
    {
        int NumOfVertex { get; }
        int NumOfEdge { get; }

        void Create();
        int[,] Get();
        int[] GetAdjacent(int vertex);
    }
}
