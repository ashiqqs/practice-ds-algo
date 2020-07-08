using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Sort
{
    public class Bubble:ISorter
    {
        /// <summary>
        /// Time Complexity 
        /// Best Case O(n) |
        /// Wrost Case O(n^2) |
        /// Average Case O(n^2) |
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public int[] Ascending(int[] items)
        {
            int endPoint = items.Length;
            for (int i = 0; i < endPoint - 1; i++)
            {
                bool isSwaped = false;
                for (int j = 0; j < endPoint - i - 1; j++)
                {
                    if (items[j] > items[j + 1])
                    {
                        int temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                        isSwaped = true;
                    }
                }
                if (!isSwaped) { break; }
            }
            return items;
        }

        public int[] Descending(int[] items)
        {
            int endPoint = items.Length;
            for (int i = 0; i < endPoint - 1; i++)
            {
                bool isSwaped = false;
                for (int j = 0; j < endPoint - i - 1; j++)
                {
                    if (items[j] < items[j + 1])
                    {
                        int temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                        isSwaped = true;
                    }
                }
                if (!isSwaped) { break; }
            }
            return items;
        }
    }
}
