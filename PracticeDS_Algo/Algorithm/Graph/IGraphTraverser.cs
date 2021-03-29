using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Graph
{
    public interface IGraphTraverser
    {
        void Traverse();
        void PrintPath();
        void PrintPrevious();
        void PrintDistance();
    }
}
