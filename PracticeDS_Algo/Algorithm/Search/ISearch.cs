using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Search
{
    public interface ISearch
    {
        /// <summary>
        /// Search a value, return the position of given value
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        int Find(int[] numbers, int item);
    }
}
