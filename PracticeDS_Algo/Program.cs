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
            ITest test = new Quick();

            test.Execute();

            Console.ReadKey();

        }

    }
}
