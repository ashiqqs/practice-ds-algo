using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Sort
{
    public class Selection: ISorter,ITest
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
            int endPoint = items.Length, smallestIndex = 0,temp;
            for (int i = 0; i < endPoint; i++)
            {
                smallestIndex = i;
                for (int j = i + 1; j < endPoint; j++)
                {
                    if (items[smallestIndex] > items[j])
                    {
                        smallestIndex = j;
                    }
                }
                if (smallestIndex!=i)
                {
                    temp = items[smallestIndex];
                    items[smallestIndex] = items[i];
                    items[i] = temp;
                }
            }
            return items;
        }
        public int[] Descending(int[] items)
        {
            int endPoint = items.Length, largestIndex = 0,temp;
            for (int i = 0; i < endPoint; i++)
            {
                largestIndex = i;
                for (int j = i + 1; j < endPoint; j++)
                {
                    if (items[largestIndex] < items[j])
                    {
                        largestIndex = j;
                    }
                }
                if (items[i] < items[largestIndex])
                {
                    temp = items[largestIndex];
                    items[largestIndex] = items[i];
                    items[i] = temp;
                }
            }
            return items;
        }
        public string[] Ascending(string[] items)
        {
            Helper helper = new Helper();
            int smallestIndex, endPoint = items.Length-1;
            string temp;
            for(int i=0; i<endPoint; i++)
            {
                smallestIndex = i;
                for (int j=i+1; j<=endPoint; j++)
                {
                    if(helper.StrComp(items[smallestIndex], items[j]) < 0)
                    {
                        smallestIndex = j;
                    }
                }
                if (i!=smallestIndex)
                {
                    temp = items[smallestIndex];
                    items[smallestIndex] = items[i];
                    items[i] = temp;
                }
            }
            return items;
        }
        public string[] Descending(string[] items)
        {
            Helper helper = new Helper();
            string temp;
            int smallestIndex, endPoint = items.Length - 1;
            for (int i = 0; i < endPoint; i++)
            {
                smallestIndex = i;
                for (int j = i + 1; j <= endPoint; j++)
                {
                    if (helper.StrComp(items[smallestIndex], items[j]) > 0)
                    {
                        smallestIndex = j;
                    }
                }
                if (i!=smallestIndex)
                {
                    temp = items[smallestIndex];
                    items[smallestIndex] = items[i];
                    items[i] = temp;
                }
            }
            return items;
        }

        public void Execute()
        {
            Helper helper = new Helper();
            ISorter sort = new Selection();
            string[] items = new string[] { "112", "102" };
            helper.PrintArray<string>(items);
            var sorted = sort.Ascending(items);
            helper.PrintArray<string>(sorted);
            var desc = sort.Descending(items);
            helper.PrintArray<string>(desc);
        }
    }
}
