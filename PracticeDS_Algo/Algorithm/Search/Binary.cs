using PracticeDS_Algo.Algorithm.Sort;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Search
{
    public class Binary:Helper,ITest,ISearch
    {
        public void Execute()
        {
            Bubble sort = new Bubble();
            int[] numbers = sort.Ascending(GetRandomNumbers(25));
            
            Console.WriteLine("Input: " + String.Join(',', numbers));
            Console.WriteLine("Search Item: ");
            int item = Convert.ToInt32(Console.ReadLine());
            Console.Write("Searching...");
            int position = Find(numbers, item);
            if (position > -1)
            {
                Console.WriteLine($"{item} found on Position {position}");
            }
            else
            {
                Console.WriteLine($"{item} not exist in list");
            }
        }

        /// <summary>
        /// Time Complexity O(logN)
        /// Space Complexity O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Find(int[] numbers, int item)
        {
            int left=0, right=numbers.Length-1, mid;
            while (left <= right)
            {
                mid = (left+right)/2;
                if (numbers[mid] == item) { 
                    return mid;
                }
                else if (item<numbers[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
