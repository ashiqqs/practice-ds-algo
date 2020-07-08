using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Sort
{
    public interface ISorter
    {
        int[] Ascending(int[] numbers);
        string[] Ascending(string[] items);
        int[] Descending(int[] numbers);
        string[] Descending(string[] items);
    }
}
