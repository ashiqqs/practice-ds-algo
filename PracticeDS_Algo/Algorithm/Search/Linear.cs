using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo.Algorithm.Search
{
    public class Linear:Helper,ISearch,ITest
    {
        public void Execute()
        {
            int[] numbers = GetRandomNumbers(15);
            Console.WriteLine("Input: " + String.Join(',', numbers));
            int item = Convert.ToInt32(Console.ReadLine());
            Console.Write("Searching...");
            int position = Find(numbers, item);
            Console.WriteLine($"{item} found on Position {position}");
        }

        /// <summary>
        /// Time Complexity O(n)
        /// Space Complexity O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Find(int[] numbers, int item)
        {
            int length = numbers.Length;
            for(int i=0; i<length; i++)
            {
                if (numbers[i]==item) {
                    return i;
                }
            }
            return -1;
        }

    }
}
