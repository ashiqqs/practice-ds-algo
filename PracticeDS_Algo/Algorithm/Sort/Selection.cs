using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Sort
{
    public class Selection: ISorter
    {
        /// <summary>
        /// Time Complexity 
        /// Best Case O(n^2) |
        /// Wrost Case O(n^2) |
        /// Average Case O(n^2) |
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public int[] Ascending(int[] items)
        {
            int endPoint = items.Length, smallest = 0, smallestIndex = 0;
            for (int i = 0; i < endPoint; i++)
            {
                smallest = items[i];
                for (int j = i + 1; j < endPoint; j++)
                {
                    if (smallest > items[j])
                    {
                        smallest = items[j];
                        smallestIndex = j;
                    }
                }
                if (items[i] > smallest)
                {
                    items[smallestIndex] = items[i];
                    items[i] = smallest;
                }
            }
            return items;
        }

        public int[] Descending(int[] items)
        {
            int endPoint = items.Length, largest = 0, largestIndex = 0;
            for (int i = 0; i < endPoint; i++)
            {
                largest = items[i];
                for (int j = i + 1; j < endPoint; j++)
                {
                    if (largest < items[j])
                    {
                        largest = items[j];
                        largestIndex = j;
                    }
                }
                if (items[i] < largest)
                {
                    items[largestIndex] = items[i];
                    items[i] = largest;
                }
            }
            return items;
        }
    }
}
